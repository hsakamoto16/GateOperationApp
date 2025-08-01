using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GateOperationApp.Models
{
    public class Receipt
    {
        [JsonProperty("medical")]
        public string Medical { get; set; } = "";
        [JsonProperty("inOut")]
        public string InOut { get; set; } = "";
        [JsonProperty("cid")]
        public string Cid { get; set; } = "";
        [JsonProperty("name")]
        public string Name { get; set; } = "";
        [JsonProperty("paymentNumber")]
        public int PaymentNumber { get; set; } = 0;
        [JsonProperty("reportNumber")]
        public int ReportNumber { get; set; } = 0;
        [JsonProperty("receiptDate")]
        public DateTime ReceiptDate { get; set; } = DateTime.Now;
        [JsonProperty("no")]
        public string No { get; set; } = "";
        [JsonProperty("dateOfIssue")]
        public string DateOfIssue { get; set; } = "";
        [JsonProperty("categoryOfExpenses")]
        public string CategoryOfExpenses { get; set; } = "";
        [JsonProperty("percentageOfBurden")]
        public string PercentageOfBurden { get; set; } = "";
        [JsonProperty("insuredType")]
        public string InsuredType { get; set; } = "";
        [JsonProperty("insuredClass")]
        public string InsuredClass { get; set; } = "";
        [JsonProperty("isPrescription")]
        public bool IsPrescription { get; set; } = false;
        [JsonProperty("medicalFee")]
        public int MedicalFee { get; set; } = 0;
        [JsonProperty("admissionFee")]
        public int AdmissionFee { get; set; } = 0;
        [JsonProperty("administrationFee")]
        public int AdministrationFee { get; set; } = 0;
        [JsonProperty("homeTreatment")]
        public int HomeTreatment { get; set; } = 0;
        [JsonProperty("inspection")]
        public int Inspection { get; set; } = 0;
        [JsonProperty("diagnosticImaging")]
        public int DiagnosticImaging { get; set; } = 0;
        [JsonProperty("dosage")]
        public int Dosage { get; set; } = 0;
        [JsonProperty("injection")]
        public int Injection { get; set; } = 0;
        [JsonProperty("rehabilitation")]
        public int Rehabilitation { get; set; } = 0;
        [JsonProperty("treatment")]
        public int Treatment { get; set; } = 0;
        [JsonProperty("surgery")]
        public int Surgery { get; set; } = 0;
        [JsonProperty("anesthesia")]
        public int Anesthesia { get; set; } = 0;
        [JsonProperty("radiotherapy")]
        public int Radiotherapy { get; set; } = 0;
        [JsonProperty("repair")]
        public int Repair { get; set; } = 0;
        [JsonProperty("orthodontics")]
        public int Orthodontics { get; set; } = 0;
        [JsonProperty("pathologicalDiagnosis")]
        public int PathologicalDiagnosis { get; set; } = 0;
        [JsonProperty("other")]
        public int Other { get; set; } = 0;
        [JsonProperty("dietaryCare")]
        public int DietaryCare { get; set; } = 0;
        [JsonProperty("lifestyleRecreation")]
        public int LifestyleRecreation { get; set; } = 0;
        [JsonProperty("evaluationClinic")]
        public int EvaluationClinic { get; set; } = 0;
        [JsonProperty("evaluationClinicDetail1")]
        public string EvaluationClinicDetail1 { get; set; } = "";
        [JsonProperty("evaluationClinicDetail2")]
        public string EvaluationClinicDetail2 { get; set; } = "";
        [JsonProperty("evaluationClinicDetail3")]
        public string EvaluationClinicDetail3 { get; set; } = "";
        [JsonProperty("otherDetail1")]
        public string OtherDetail1 { get; set; } = "";
        [JsonProperty("otherDetail2")]
        public string OtherDetail2 { get; set; } = "";
        [JsonProperty("otherDetail3")]
        public string OtherDetail3 { get; set; } = "";
        [JsonProperty("totalInsuranceScore")]
        public int TotalInsuranceScore { get; set; } = 0;
        [JsonProperty("totalLifeScore")]
        public int TotalLifeScore { get; set; } = 0;
        [JsonProperty("totalOtherScore")]
        public int TotalOtherScore { get; set; } = 0;
        [JsonProperty("burdenInsuranceScore")]
        public int BurdenInsuranceScore { get; set; } = 0;
        [JsonProperty("burdenLifeScore")]
        public int BurdenLifeScore { get; set; } = 0;
        [JsonProperty("burdenOtherScore")]
        public int BurdenOtherScore { get; set; } = 0;
        [JsonProperty("goodsYen")]
        public int GoodsYen { get; set; } = 0;
        [JsonProperty("goodsYenTax")]
        public int GoodsYenTax { get; set; } = 0;
        [JsonProperty("goodsYenReduced")]
        public int GoodsYenReduced { get; set; } = 0;
        [JsonProperty("goodsYenReducedTax")]
        public int GoodsYenReducedTax { get; set; } = 0;
        [JsonProperty("expenseYen")]
        public int ExpenseYen { get; set; } = 0;
        [JsonProperty("expenseYenTax")]
        public int ExpenseYenTax { get; set; } = 0;
        [JsonProperty("expenseYenReduced")]
        public int ExpenseYenReduced { get; set; } = 0;
        [JsonProperty("expenseYenReducedTax")]
        public int ExpenseYenReducedTax { get; set; } = 0;
        [JsonProperty("adjustmentYen")]
        public int AdjustmentYen { get; set; } = 0;
        [JsonProperty("totalCost")]
        public int TotalCost { get; set; } = 0;
        [JsonProperty("totalOtherYen")]
        public int TotalOtherYen { get; set; } = 0;
        [JsonProperty("totalOtherYen2")]
        public int TotalOtherYen2 { get; set; } = 0;
        [JsonProperty("isUnpaid")]
        public bool IsUnpaid { get; set; } = false;
        [JsonProperty("dentistCode")]
        public string DentistCode { get; set; } = "";
        [JsonProperty("dentistName")]
        public string DentistName { get; set; } = "";
        [JsonProperty("homeClass")]
        public string HomeClass { get; set; } = "";
        [JsonProperty("key")]
        public string Key { get; set; } = "";
        [JsonProperty("detail")]
        public List<ReceiptItem> Detail { get; set; } = new List<ReceiptItem>();
    }

    public class GateReceiptHeader
    {
        [JsonProperty("kbn")]
        public int Kbn { get; set; }
        [JsonProperty("receiptNo")]
        public string ReceiptNo { get; set; } = ""; // 領収証番号
        [JsonProperty("cid")]
        public string Cid { get; set; } = ""; //カルテ番号
        [JsonProperty("name")]
        public string? Name { get; set; } //患者氏名
        [JsonProperty("dateOfIssue")]
        public string DateOfIssue { get; set; } = ""; // 領収証発行日
        [JsonProperty("receiptDate")]
        public string ReceiptDate { get; set; } = ""; // 診療日
        [JsonProperty("medical")]
        public string? Medical { get; set; } // 診療科
        [JsonProperty("inOut")]
        public string? InOut { get; set; } // '入院', '外来', ''
        [JsonProperty("categoryOfExpenses")]
        public string? CategoryOfExpenses { get; set; } // 費用区分
        [JsonProperty("percentageOfBurden")]
        public string? PercentageOfBurden { get; set; } // 負担割合
        [JsonProperty("insuredType")]
        public string? InsuredType { get; set; } // 本人家族
        [JsonProperty("homeClass")]
        public string? HomeClass { get; set; } // 在宅区分
        [JsonProperty("insuredClass")]
        public string? InsuredClass { get; set; } // 保険種別
        [JsonProperty("isPrescription")]
        public bool? IsPrescription { get; set; } // 処方
        [JsonProperty("medicalFeeScore")]
        public int? MedicalFeeScore { get; set; } // 初再診料
        [JsonProperty("admissionFeeScore")]
        public int? AdmissionFeeScore { get; set; } // 入院料等
        [JsonProperty("administrationFeeScore")]
        public int? AdministrationFeeScore { get; set; } // 医学管理等
        [JsonProperty("homeTreatmentScore")]
        public int? HomeTreatmentScore { get; set; } // 在宅医療
        [JsonProperty("inspectionScore")]
        public int? InspectionScore { get; set; } // 検査
        [JsonProperty("diagnosticImagingScore")]
        public int? DiagnosticImagingScore { get; set; } // 画像診断
        [JsonProperty("dosageScore")]
        public int? DosageScore { get; set; } // 投薬
        [JsonProperty("injectionScore")]
        public int? InjectionScore { get; set; } // 注射
        [JsonProperty("rehabilitationScore")]
        public int? RehabilitationScore { get; set; } // リハビリテーション
        [JsonProperty("treatmentScore")]
        public int? TreatmentScore { get; set; } // 処置
        [JsonProperty("surgeryScore")]
        public int? SurgeryScore { get; set; } // 手術
        [JsonProperty("anesthesiaScore")]
        public int? AnesthesiaScore { get; set; } // 麻酔
        [JsonProperty("radiotherapyScore")]
        public int? RadiotherapyScore { get; set; } // 放射線治療
        [JsonProperty("otherScore")]
        public int? OtherScore { get; set; } // その他
        [JsonProperty("repairScore")]
        public int? RepairScore { get; set; } // 歯冠修復及び欠損補綴
        [JsonProperty("orthodonticsScore")]
        public int? OrthodonticsScore { get; set; } // 歯科矯正
        [JsonProperty("pathologicalDiagnosisScore")]
        public int? PathologicalDiagnosisScore { get; set; } // 病理診断
        [JsonProperty("dietaryCareScore")]
        public int? DietaryCareScore { get; set; } // 食事療養
        [JsonProperty("lifestyleRecreationScore")]
        public int? LifestyleRecreationScore { get; set; } // 生活療養
        [JsonProperty("totalInsuranceScore")]
        public int? TotalInsuranceScore { get; set; } // 保険分合計点数
        [JsonProperty("burdenInsuranceYen")]
        public int? BurdenInsuranceYen { get; set; } // 保険分負担金額
        [JsonProperty("totalOtherYen")]
        public int? BurdenOtherYen { get; set; } // 保険外合計金額
        [JsonProperty("totalOtherYen2")]
        public int? BurdenOtherYen2 { get; set; } // 保険外合計金額
        [JsonProperty("adjustmentYen")]
        public int? AdjustmentYen { get; set; } // 調整金額
        [JsonProperty("totalYen")]
        public int? TotalYen { get; set; } // 請求額合計
        [JsonProperty("isUnpaid")]
        public bool? IsUnpaid { get; set; } // 前回未収金あり
        [JsonProperty("dentistCode")]
        public string? DentistCode { get; set; } // 診療者コード
        [JsonProperty("dentistName")]
        public string? DentistName { get; set; } // 診療者名
        [JsonProperty("goodsYen")]
        public int? GoodsYen { get; set; } // 物販負担額
        [JsonProperty("goodsYenTax")]
        public int? GoodsYenTax { get; set; } // 物販消費税額
        [JsonProperty("goodsYenReduced")]
        public int? GoodsYenReduced { get; set; } // 物販軽減税合計
        [JsonProperty("goodsYenReducedTax")]
        public int? GoodsYenReducedTax { get; set; } // 物販軽減税減税合計
        [JsonProperty("expenseYen")]
        public int? ExpenseYen { get; set; } // 自費負担額
        [JsonProperty("expenseYenTax")]
        public int? ExpenseYenTax { get; set; } // 自費消費税額
        [JsonProperty("expenseYenReduced")]
        public int? ExpenseYenReduced { get; set; } // 自費軽減税合計
        [JsonProperty("expenseYenReducedTax")]
        public int? ExpenseYenReducedTax { get; set; } // 自費軽減税減税合計

        [JsonProperty("key")]
        public string? Key { get; set; } // 連動キー

        public GateReceiptHeader() { }
        public GateReceiptHeader(Receipt receipt)
        {
            ReceiptNo = receipt.No;
            InOut = receipt.InOut;
            Cid = receipt.Cid;
            Name = receipt.Name;
            DateOfIssue = receipt.DateOfIssue;
            ReceiptDate = receipt.ReceiptDate.ToString("yyyy-MM-dd");
            Medical = receipt.Medical;
            InOut = receipt.InOut;
            CategoryOfExpenses = receipt.CategoryOfExpenses;
            PercentageOfBurden = receipt.PercentageOfBurden;
            InsuredType = receipt.InsuredType;
            HomeClass = receipt.HomeClass;
            InsuredClass = receipt.InsuredClass;
            IsPrescription = receipt.IsPrescription;
            MedicalFeeScore = receipt.MedicalFee;
            AdmissionFeeScore = receipt.AdmissionFee;
            AdministrationFeeScore = receipt.AdministrationFee;
            HomeTreatmentScore = receipt.HomeTreatment;
            InspectionScore = receipt.Inspection;
            DiagnosticImagingScore = receipt.DiagnosticImaging;
            DosageScore = receipt.Dosage;
            InjectionScore = receipt.Injection;
            RehabilitationScore = receipt.Rehabilitation;
            TreatmentScore = receipt.Treatment;
            SurgeryScore = receipt.Surgery;
            AnesthesiaScore = receipt.Anesthesia;
            RadiotherapyScore = receipt.Radiotherapy;
            RepairScore = receipt.Repair;
            OrthodonticsScore = receipt.Orthodontics;
            PathologicalDiagnosisScore = receipt.PathologicalDiagnosis;
            OtherScore = receipt.Other;
            DietaryCareScore = receipt.DietaryCare;
            LifestyleRecreationScore = receipt.LifestyleRecreation;
            TotalInsuranceScore = receipt.TotalInsuranceScore;
            BurdenInsuranceYen = receipt.BurdenInsuranceScore;
            BurdenOtherYen = receipt.TotalOtherScore;
            AdjustmentYen = receipt.AdjustmentYen;
            GoodsYen = receipt.GoodsYen;
            TotalYen = receipt.TotalCost;
            IsUnpaid = receipt.IsUnpaid;
            DentistCode = receipt.DentistCode;
            DentistName = receipt.DentistName;
            Key = receipt.Key;
        }
    }

    public class ReceiptItem
    {
        [JsonProperty("itemType")]
        public string ItemType { get; set; } = ""; // 分類[処置、材料、薬剤、その他]

        [JsonProperty("itemTypeSub")]
        public string ItemTypeSub { get; set; } = ""; // 分類サブ

        [JsonProperty("item")]
        public string Item { get; set; } = ""; // 項目名

        [JsonProperty("mark")]
        public string Mark { get; set; } = "";

        [JsonProperty("category")]
        public string Category { get; set; } = ""; //  区分[初再診料, 

        [JsonProperty("score")]
        public string Score { get; set; } = "";

        [JsonProperty("count")]
        public string Count { get; set; } = "";

        [JsonProperty("sales")]
        public int Sales { get; set; } = 0; // 金額

        [JsonProperty("tax")]
        public string Tax { get; set; } = "";

        [JsonProperty("taxRate")]
        public double TaxRate { get; set; } = 0;

        [JsonProperty("taxKbn")]
        public string TaxKbn { get; set; } = "";
    }
    public class GateDetail
    {
        [JsonProperty("receiptNo")]
        public string ReceiptNo { get; set; } = "";
        [JsonProperty("cid")]
        public string Cid { get; set; } = "";
        [JsonProperty("name")]
        public string Name { get; set; } = "";
        [JsonProperty("receiptDate")]
        public string ReceiptDate { get; set; } = "";
        [JsonProperty("dentistCode")]
        public string DentistCode { get; set; } = "";
        [JsonProperty("dentistName")]
        public string DentistName { get; set; } = "";
        [JsonProperty("items")]
        public List<GateDetailItem> Items { get; set; } = new List<GateDetailItem>();

        public GateDetail() { }
        public GateDetail(Receipt receipt)
        {
            ReceiptNo = receipt.No;
            Cid = receipt.Cid;
            Name = receipt.Name;
            ReceiptDate = receipt.ReceiptDate.ToString("yyyy-MM-dd");
            DentistCode = receipt.DentistCode;
            DentistName = receipt.DentistName;
            var uploadDetailItems = new List<GateDetailItem>();
            int itemIndex = 0;
            foreach (var item in receipt.Detail)
            {
                var uploadDetailItem = new GateDetailItem(item);
                uploadDetailItem.Index = itemIndex;
                uploadDetailItems.Add(uploadDetailItem);
                itemIndex++;
            }
            Items = uploadDetailItems;
        }
    }

    public class GateDetailItem
    {
        [JsonProperty("class")]
        public string @Class { get; set; } = "";
        [JsonProperty("index")]
        public int Index { get; set; } = 0;
        [JsonProperty("type")]
        public string Type { get; set; } = "";
        [JsonProperty("mark")]
        public string Mark { get; set; } = "";
        [JsonProperty("itemName")]
        public string ItemName { get; set; } = "";
        [JsonProperty("score")]
        public string Score { get; set; } = "";
        [JsonProperty("yen")]
        public int Yen { get; set; } = 0;
        [JsonProperty("count")]
        public string Count { get; set; } = "";
        [JsonProperty("tax")]
        public int Tax { get; set; } = 0;
        [JsonProperty("taxRate")]
        public int TaxRate { get; set; } = 0;
        //[JsonProperty("taxKbn")]
        //public string TaxKbn { get; set; } = "";

        public GateDetailItem() { }
        public GateDetailItem(ReceiptItem receiptItem)
        {
            @Class = receiptItem.ItemType;
            Type = receiptItem.ItemTypeSub;
            Mark = receiptItem.Mark;
            ItemName = receiptItem.Item;
            Score = receiptItem.Score;
            Yen = receiptItem.Sales;
            Count = receiptItem.Count;
            Tax = int.TryParse(receiptItem.Tax, out int tax) ? tax : 0;
            TaxRate = (int)receiptItem.TaxRate;
            //TaxKbn = receiptItem.TaxKbn;
        }
    }
}
