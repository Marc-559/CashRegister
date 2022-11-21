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
            Printer printer = new Printer("POS-58");                //Welcher Drucker benutzt wird
            printer.Append("Martins Käslada");                      //EIne Zeile ausgeben
            printer.Append("Adresse");
            printer.Append("Ort");
            printer.Append("TelefonNummer:");
            printer.Append("helpEmail");
            printer.Append("--------------------------------");
            printer.Append("Kaufdatum:   " + DateTime.Now);
            printer.Append("--------------------------------");
            PrintProducts(einkaufsPositionList, printer);           //Gibts alle Produkte aus
            printer.Append("--------------------------------");

            //Abstand für die jeweiligen Zeichen berechnen
            string spaceSum = Spacing(25, 6, Math.Round(belegData.GetGesamtPreis(einkaufsPositionList), 2).ToString().Length);
            string spaceGegeben = Spacing(25, 16, Math.Round(Convert.ToDecimal(Gegebenesgeld), 2).ToString("F2").Length);
            string spaceRueckgeld = Spacing(25, 9, Math.Round((Convert.ToDecimal(Gegebenesgeld) - belegData.GetGesamtPreis(einkaufsPositionList)), 2).ToString().Length);

            printer.Append("Summe:" + spaceSum + Math.Round(belegData.GetGesamtPreis(einkaufsPositionList), 2) + "  CHF");
            printer.Append("--------------------------------");
            printer.Append("Gegebenses Geld:" + spaceGegeben + Convert.ToDecimal(Gegebenesgeld).ToString("F2") + "  CHF");
            printer.Append("Rückgeld:" + spaceRueckgeld + Math.Round((Convert.ToDecimal(Gegebenesgeld) - belegData.GetGesamtPreis(einkaufsPositionList)), 2) + "  CHF");
            printer.Append(" ");
            printer.Append(" ");
            printer.Append(" ");
            printer.Append(" ");
            printer.PrintDocument();
        }

        private void PrintProducts(List<EinkaufsPosition> einkaufsPositionList, Printer printer)
        {
            foreach (EinkaufsPosition einkaufsPosition in einkaufsPositionList)
            {
                string space = Spacing(25, einkaufsPosition.Produkt.Name.Length, Math.Round((einkaufsPosition.Produkt.Preis * einkaufsPosition.Anzahl), 2).ToString().Length);

                printer.Append(einkaufsPosition.Produkt.Name + space + Math.Round((einkaufsPosition.Produkt.Preis * einkaufsPosition.Anzahl), 2) + "  CHF");
            }
        }

        //Berechnet den Abstand zwischen dem Namen und dem Preis(String:------Zahl)
        private string Spacing(int spaceCount, int PoductLenght, int priceLenght)
        {
            string space = "";
            for (int i = 0; i < (spaceCount - PoductLenght - priceLenght); i++)
            {
                space = space + " ";
            }
            return space;
        }
    }
}
