using hyp_connect.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace hyp_connect
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Ad> getAllAds();
        [OperationContract]
        Ad addAd(Ad ad);


        [OperationContract]
        List<Report> getAllReports();
        [OperationContract]
        Report addReport(Report report);
        [OperationContract]
        void updateReportRSTATUS(int id,int newStatus);

    }





}
