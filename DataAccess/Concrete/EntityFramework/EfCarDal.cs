using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    // Oluşturduğumuz Ef baseyi buraya referans olarak verdik. 
    // Generic yapıyı Ef'mize göre doldurduk ayrıca onun bir CarDal olduğunu belirttik.
    // burada ki işlemler aslında Basede yönetiliyor 
    //fakat consolumuzda yeni bir nesne newlediğimiz de () içine hangi Ef ile işlem yapmamızı istediğimizi sağlıyor.


    public class EfCarDal : EfEntityRepositoryBase<Car, ProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
