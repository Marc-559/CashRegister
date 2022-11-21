using CashRegister.DAL;
using CashRegister.Models;
using CashRegister_DAL.DataAccessLayer;
using ESC_POS_USB_NET.Printer;
using System.Drawing.Printing;

namespace CashRegister_App.Data
{
    public class PrintService
    {
        CashRegisterContextDB context = new CashRegisterContextDB();
        BelegDAL belegData;
        public PrintService(CashRegisterContextDB context)
        {
            this.context = context;
            belegData = new BelegDAL(context);
        }
        
        public void PrintBeleg(List<EinkaufsPosition> einkaufsPositionList, string Gegebenesgeld)
        {

            Printer printer = new Printer("POS-58");
            printer.Append("Martins Käslada");
            printer.Append("Adresse");
            printer.Append("Ort");
            printer.Append("TelefonNummer:");
            printer.Append("helpEmail");
            printer.Append("--------------------------------");
            printer.Append("Kaufdatum:   " + DateTime.Now);
            printer.Append("--------------------------------");
            foreach (EinkaufsPosition einkaufsPosition in einkaufsPositionList)
            {
                string space = spacing(25, einkaufsPosition.Produkt.Name.Length, (einkaufsPosition.Produkt.Preis * einkaufsPosition.Anzahl).ToString().Length);

                printer.Append(einkaufsPosition.Produkt.Name + space + (einkaufsPosition.Produkt.Preis * einkaufsPosition.Anzahl) + "  CHF");
            }

            printer.Append("--------------------------------");

            string spaceSum = spacing(25,6, belegData.GetGesamtPreis(einkaufsPositionList).ToString().Length);
            string spaceGegeben = spacing(25, 16, Convert.ToDecimal(Gegebenesgeld).ToString("F2").Length);
            string spaceRueckgeld = spacing(25, 9, (Convert.ToDouble(Gegebenesgeld) - belegData.GetGesamtPreis(einkaufsPositionList)).ToString().Length);

            printer.Append("Summe:" + spaceSum + belegData.GetGesamtPreis(einkaufsPositionList) + "  CHF");
            printer.Append("--------------------------------");
            printer.Append("Gegebenses Geld:" + spaceGegeben + Convert.ToDecimal(Gegebenesgeld).ToString("F2") + "  CHF");
            printer.Append("Rückgeld:" + spaceRueckgeld + (Convert.ToDouble(Gegebenesgeld) - belegData.GetGesamtPreis(einkaufsPositionList)) + "  CHF");
            printer.Append(" ");
            printer.Append(" ");
            printer.Append(" ");
            printer.Append(" ");
           // printer.PrintDocument();
        }
        private string spacing(int spaceCount, int PoductLenght, int priceLenght)
        {
            string space = "";
            for (int i = 0; i < (spaceCount - PoductLenght - priceLenght); i++)
            {
                space = space + " ";
            }
            return space;
        }

        public List<string> GetPrinters()
        {
            List<string> printerList = new List<string>();
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                printerList.Add(printname);
            }
            return printerList;
        }
    }
}
