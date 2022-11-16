using CashRegister.DAL;
using CashRegister.Models;


namespace CashRegister_DAL.DataAccessLayer
{
    public class EinkaufsPositionDAL
    {
        CashRegisterContextDB context = new CashRegisterContextDB();
        public EinkaufsPositionDAL(CashRegisterContextDB context)
        {
            this.context = context;
        }


        public void Create(int anzahl, Produkt produkt, List<EinkaufsPosition> einkaufsPositionAktuell)
        {
            EinkaufsPosition einkaufsPosition = new EinkaufsPosition
            {
                Anzahl = anzahl,
                Produkt = produkt,
            };
            einkaufsPositionAktuell.Add(einkaufsPosition);
            context.Add(einkaufsPosition);
        }



        public void Update(int anzahl, List<EinkaufsPosition> einkaufsPositionAktuell)
        {
            EinkaufsPosition einkaufsposition = new EinkaufsPosition();

            foreach (EinkaufsPosition einkaufspositionsitem in einkaufsPositionAktuell)
            {
                einkaufsposition = (EinkaufsPosition)context.EinkaufsPosition.Where(x => x.Id == einkaufspositionsitem.Id);
            }
            einkaufsposition.Anzahl = anzahl;
            context.SaveChanges();
        }

    }
}