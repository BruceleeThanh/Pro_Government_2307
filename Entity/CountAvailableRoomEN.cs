using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Entity {
    public class CountAvailableRoomEN : sp_Room_CountAvailableRooms_ByType_ByTime_ByLang_Result {

        public void SetValue (sp_Room_CountAvailableRooms_ByType_ByTime_ByLang_Result para) {
            this.Suite = para.Suite;
            this.Standard = para.Standard;
            this.Superior = para.Superior;
        }
    }
}
