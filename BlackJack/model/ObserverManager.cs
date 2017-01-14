//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace BlackJack.model
//{
//    class ObserverManager
//    {
//        private List<Observer>m_list = new List<Observer>();
//        private static ObserverManager m_instance;

//        public static ObserverManager Instance()
//        {
//            if (m_instance == null)
//            {
//                m_instance = new ObserverManager();
//            }
//            return m_instance;
//        }

//        public void Attch(Observer obser)
//        {
//            m_list.Add(obser);
//        }

//        public void Detach(Observer obser)
//        {
//            m_list.Remove(obser);
//        }

//        public void Notify()
//        {
//            foreach(Observer data in m_list)
//            {
//                data.Update();
//            }

//            m_list.Clear();
//        }
//    }
//}
