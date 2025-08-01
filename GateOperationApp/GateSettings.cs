using Reactive.Bindings;
using Reactive.Bindings.Disposables;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GateOperationApp
{
    public class GateSettings : INotifyPropertyChanged, IDisposable
    {
        private readonly CompositeDisposable _disposables = new CompositeDisposable();

        //public ReactivePropertySlim<string> GateUrl { get; private set; } = new ReactivePropertySlim<string>("https://dev.plum-gate.com"); // ゲートURL
        //public ReactivePropertySlim<string> GateToken { get; private set; } = new ReactivePropertySlim<string>("DjdfeDDFEkdiifewjnkdiwo8865dDfe866dKdfe"); // ゲートID
        public ReactivePropertySlim<string> GateUrl { get; private set; } = new ReactivePropertySlim<string>(""); // ゲートURL
        public ReactivePropertySlim<string> GateToken { get; private set; } = new ReactivePropertySlim<string>(""); // ゲートID
        public ReactivePropertySlim<bool> IsEditable { get; private set; }  = new ReactivePropertySlim<bool>(true); // 編集モード
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void Dispose()
        {
            // まとめてDisposeする
            _disposables.Dispose();
        }
    }
}
