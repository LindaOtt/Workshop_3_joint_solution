using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace BlackJack.model
//{
//    class Observer
//    {
//        private object obj;
//        public delegate void UserRequest(object sender, EventArgs e);
//        public event UserRequest OnUserRequest;

//        public Observer(object obj)
//        {
//            this.obj = obj;
//        }

//        public void Update()
//        {
//        }
//    }
//}

interface Observer
{
    void Update();
}
