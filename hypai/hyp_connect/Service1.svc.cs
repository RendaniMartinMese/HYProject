using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using hyp_connect.model;

namespace hyp_connect
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private hyp_linqDataContext data_context = new hyp_linqDataContext();

        public Ad addAd(Ad ad)
        {
            data_context.Ads.InsertOnSubmit(ad);
            data_context.SubmitChanges();
            return ad;

        }
        public Report addReport(Report report)
        {
            data_context.Reports.InsertOnSubmit(report);
            data_context.SubmitChanges();
            return report;
        }
        public List<Ad> getAllAds()
        {
            var Ads = data_context.Ads;
            return Ads.ToList();
        }
        public List<Report> getAllReports()
        {
            var reports = data_context.Reports;
            return reports.ToList();
        }
        public void updateReportRSTATUS(int id, int newStatus)
        {
            Report report = (from R in data_context.Reports
                             where R.REPORT_ID == id
                             select R).SingleOrDefault();
            report.READ_STATUS = newStatus;
            data_context.SubmitChanges();
        }
    }
}
