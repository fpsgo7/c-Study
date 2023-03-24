using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    class UserVO
    {
        public string order;
        string name;
        string contact;
        public string Order { get; set; }
        public string Name 
        {
            get{ return name; }
            set { name = value; }
         }
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        public UserVO()
        {

        }
        public UserVO(string order, string name, string context)
        {
            this.order = order;
            this.name = name;
            this.contact = context;
        }
        public UserVO(string[] values)
        {
            this.order = values[0];
            this.name = values[1];
            this.contact = values[2];
        }
    }
}
