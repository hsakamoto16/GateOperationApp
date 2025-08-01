using Newtonsoft.Json;
using Reactive.Bindings;
using Reactive.Bindings.Disposables;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GateOperationApp.Service;
using GateOperationApp.Models;
using System.Text.RegularExpressions;

namespace GateOperationApp.ViewModels
{
    public class GateReceiptViewModel : IDisposable
    {
        public GateSettings? gateSettings => App.Current.Resources["GateSettings"] as GateSettings;

        public ReactivePropertySlim<string> ReceiptNo { get; private set; } = new ReactivePropertySlim<string>(""); // 領収証番号
        public ReactivePropertySlim<string> Cid { get; private set; } = new ReactivePropertySlim<string>(""); // カルテ番号
        public ReactivePropertySlim<string?> Name { get; private set; } = new ReactivePropertySlim<string?>(""); // 患者氏名
        public ReactivePropertySlim<string> DateOfIssue { get; private set; } = new ReactivePropertySlim<string>(""); // 領収証発行日
        public ReactivePropertySlim<string> ReceiptDate { get; private set; } = new ReactivePropertySlim<string>(""); // 診療日
        public ReactivePropertySlim<int> TotalYen { get; private set; } = new ReactivePropertySlim<int>(0); // 請求額合計

        private readonly CompositeDisposable _disposables = new CompositeDisposable();

        public ReactiveCommandSlim OnClickGetReceiptCommand { get; }
        public ReactiveCommandSlim OnClickDeleteReceiptCommand { get; }

        public GateReceiptViewModel()
        {
            OnClickGetReceiptCommand = new ReactiveCommandSlim().WithSubscribe(GetReceiptAsync).AddTo(_disposables);
            OnClickDeleteReceiptCommand = new ReactiveCommandSlim().WithSubscribe(DeleteReceiptAsync).AddTo(_disposables);

        }

        private GateApi? _gateApi = null;
        private string GetBaseUrl(string gateUrl)
        {
            string pattern = @"^https?://[^/]+";
            var match = Regex.Match(gateUrl, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Value; // マッチした部分を返す（例: "https://*.plum-gate.com"）
            }
            return gateUrl; // マッチしなかった場合は元の文字列を返す
        }
        private bool InitializeGateApi(ref GateApi? gateApi)
        {
            if (gateSettings == null || gateSettings.GateUrl.Value == "" || gateSettings.GateToken.Value == "")
            {
                return false;
            }
            if (gateApi == null)
            {
                string baseUrl = GetBaseUrl(gateSettings.GateUrl.Value);
                gateApi = new GateApi(baseUrl, gateSettings.GateToken.Value.Trim());
                gateSettings.IsEditable.Value = false; // 編集モードを無効化
            }
            return true;
        }
        public async void GetReceiptAsync()
        {
            if (!InitializeGateApi(ref _gateApi))
            {
                MessageBox.Show("ゲートの設定が正しくありません。URLとアクセスキーを確認してください。", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                var receipt = await _gateApi!.GetReceiptWithNoAsync(ReceiptNo.Value);
                if (receipt != null)
                {
                    Cid.Value = receipt.Cid;
                    Name.Value = receipt.Name;
                    DateOfIssue.Value = receipt.DateOfIssue;
                    ReceiptDate.Value = receipt.ReceiptDate.ToString("yyyy-MM-dd");
                    TotalYen.Value = receipt.TotalCost;
                }
                else
                {
                    // 取得できなかった場合の処理
                    MessageBox.Show("領収証が見つかりませんでした。", "警告", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public async void DeleteReceiptAsync()
        {

            var messageResult = MessageBox.Show($"領収書番号: {ReceiptNo.Value} を削除しますか？\r\nカルテ番号: {Cid.Value}\r\n名前: {Name.Value}\r\n請求金額: {TotalYen.Value:N0}円", "領収書の削除", MessageBoxButton.YesNo);
            if (messageResult != MessageBoxResult.Yes)
            {
                return; // ユーザーが削除をキャンセルした場合は何もしない
            }

            if (!InitializeGateApi(ref _gateApi))
            {
                MessageBox.Show("ゲートの設定が正しくありません。URLとアクセスキーを確認してください。", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                var result = await _gateApi!.DeleteReceiptAsync(ReceiptNo.Value);
                if (result)
                {
                    MessageBox.Show("領収証が削除されました。");
                }
                else
                {
                    // 取得できなかった場合の処理
                    MessageBox.Show("削除に失敗しました。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void Dispose()
        {
            _disposables.Dispose();
        }
    }
}
