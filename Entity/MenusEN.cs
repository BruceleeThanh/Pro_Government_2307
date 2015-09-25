using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace Entity
{
    public class MenusEN : Menus
    {
        public string CodeHall { get; set; }
        public string SkuHall { get; set; }
        public string NameFood { get; set; }
        public decimal? PriceMenu { get; set;}

        public List<Foods> aListFoods = new List<Foods>();

        public void Clone(MenusEN aMenusEN)
        {
            this.CodeHall = aMenusEN.CodeHall;
            this.Disable = aMenusEN.Disable;
            this.ID = aMenusEN.ID;
            this.IDBookingHall = aMenusEN.IDBookingHall;
            this.IDSystemUser = aMenusEN.IDSystemUser;
            this.Info = aMenusEN.Info;
            this.Issue = aMenusEN.Issue;
            this.Name = aMenusEN.Name;
            this.NameFood = aMenusEN.NameFood;
            this.PriceMenu = aMenusEN.PriceMenu;
            this.SkuHall = aMenusEN.SkuHall;
            this.Status = aMenusEN.Status;
            this.Type = aMenusEN.Type;

            this.aListFoods.Clear();
            this.aListFoods.AddRange(aMenusEN.aListFoods);
        }
        public int InsertFood(Foods aFood)
        {
            try
            {
                this.aListFoods.Add(aFood);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(string.Format("MenusEN.InsertFood :" + ex.Message.ToString()));

            }
        }
        public int RemoveFood(Foods aFood)
        {
            try
            {
                int ID = aFood.ID;
                if (this.aListFoods.Where(a => a.ID == ID).ToList().Count > 0)
                {
                    this.aListFoods.Remove(this.aListFoods.Where(a => a.ID == ID).ToList()[0]);
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(string.Format("MenusEN.UpdateService :" + ex.Message.ToString()));

            }
        }
    }
}
