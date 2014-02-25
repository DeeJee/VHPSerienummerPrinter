//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Windows.Documents;
//using System.Windows;
//using VHPSerienummerPrinter;


//namespace VHPSerienummerPrinter.Printing
//{
//    public class LabelPaginator : DocumentPaginator
//    {
//        private Stuklijst _stuklijst;

//        public LabelPaginator(Stuklijst stuklijst)
//        {
//            _stuklijst = stuklijst;
//        }


//        public override DocumentPage GetPage(int pageNumber)
//        {
//            DocumentPage result = new DocumentPage(new Label());

//            return result;
//        }

//        public override bool IsPageCountValid
//        {
//            get { return true; }
//        }

//        public override int PageCount
//        {
//            get { return _stuklijst.Labels.Count(); }
//        }

//        public override System.Windows.Size PageSize
//        {
//            get
//            {
//                throw new NotImplementedException();
//            }
//            set
//            {
//                throw new NotImplementedException();
//            }
//        }

//        public override IDocumentPaginatorSource Source
//        {
//            get { return null; }
//        }
//    }
//}
