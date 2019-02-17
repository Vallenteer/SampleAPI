using SampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace SampleAPI.Controllers
{
    public class KaryawanController : ApiController
    {
        //POST: karyawan/get/1
        public async Task<IHttpActionResult> Get()
        {
            string success = "true";
            // Model Validation 
            if (ModelState.IsValid)
            {


                //Save to DB
                try
                {
                    #region Save to Database
                    using (insightiadbEntities de = new insightiadbEntities())
                    {
                        var listKaryawan = de.karyawan_test.Where(x => true).Select(a => new
                        {
                            id = a.id,
                            name = a.nama,
                            roles = a.jabatan
                        }).ToList();


                        return Json(new { result = listKaryawan });

                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    return Json(new { message = message });
                }


            }
            else
            {
                string modelErrors = "Invalid Request";
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var modelError in modelState.Errors)
                    {
                        modelErrors = modelError.ErrorMessage;
                    }
                }

                return Json(new { message = modelErrors });
            }
        }

        //POST: karyawan/get/1
        public async Task<IHttpActionResult> Get(int id)
        {
            string success = "true";
            // Model Validation 
            if (ModelState.IsValid)
            {


                //Save to DB
                try
                {
                    #region Save to Database
                    using (insightiadbEntities de = new insightiadbEntities())
                    {
                        var listKaryawan = de.karyawan_test.Where(x => x.id==id).Select(a => new
                        {
                            id = a.id,
                            name = a.nama,
                            roles=a.jabatan
                        }).ToList();


                        return Json(new { result = listKaryawan });

                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    return Json(new { message = message });
                }


            }
            else
            {
                string modelErrors = "Invalid Request";
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var modelError in modelState.Errors)
                    {
                        modelErrors = modelError.ErrorMessage;
                    }
                }

                return Json(new { message = modelErrors });
            }
        }
        //POST: karyawan/Add 
        public async Task<IHttpActionResult> Put([FromBody]karyawan_test karyawan)
        {
            string success = "true";
            // Model Validation 
            if (ModelState.IsValid)
            {


                //Save to DB
                try
                {
                    #region Save to Database
                    using (insightiadbEntities de = new insightiadbEntities())
                    {
                        de.karyawan_test.Add(karyawan);
                        de.SaveChanges();


                        return Json(new { result = success });

                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    return Json(new { message = message });
                }


            }
            else
            {
                string modelErrors = "Invalid Request";
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var modelError in modelState.Errors)
                    {
                        modelErrors = modelError.ErrorMessage;
                    }
                }

                return Json(new { message = modelErrors });
            }
        }
        //POST: karyawan/Add 
        public async Task<IHttpActionResult> Post([FromBody]karyawan_test karyawan)
        {
            string success = "true";
            // Model Validation 
            if (ModelState.IsValid)
            {


                //Save to DB
                try
                {
                    #region Save to Database
                    using (insightiadbEntities de = new insightiadbEntities())
                    {
                        de.karyawan_test.Add(karyawan);
                        de.SaveChanges();


                        return Json(new { result = success });

                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    return Json(new { message = message });
                }


            }
            else
            {
                string modelErrors = "Invalid Request";
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var modelError in modelState.Errors)
                    {
                        modelErrors = modelError.ErrorMessage;
                    }
                }

                return Json(new { message = modelErrors });
            }
        }

        //POST: karyawan/get/1
        public async Task<IHttpActionResult> Delete(int id)
        {
            string success = "true";
            // Model Validation 
            if (ModelState.IsValid)
            {


                //Save to DB
                try
                {
                    #region Save to Database
                    using (insightiadbEntities de = new insightiadbEntities())
                    {
                        var listKaryawan = de.karyawan_test.Where(x => x.id == id).Select(a => new
                        {
                            id = a.id,
                            name = a.nama,
                            roles = a.jabatan
                        }).ToList();


                        return Json(new { result = listKaryawan });

                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    return Json(new { message = message });
                }


            }
            else
            {
                string modelErrors = "Invalid Request";
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var modelError in modelState.Errors)
                    {
                        modelErrors = modelError.ErrorMessage;
                    }
                }

                return Json(new { message = modelErrors });
            }
        }

    }
}