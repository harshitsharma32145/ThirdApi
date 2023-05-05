using DocumentFormat.OpenXml.Wordprocessing;

namespace thirdapi.repository3
{
    public class Employee_Class : Empoyee_Interface
    {



        public List<Harshit17> Get_Data()
        {
            sdirectdbContext sdirectdb = new sdirectdbContext();
            var data = sdirectdb.Harshit17s.Where(x=>x.IsDeleted==false).ToList();
            return data;
        }
        public Harshit17 Getbyid(int id)
        {
            Harshit17 harshit = new Harshit17();
            sdirectdbContext sdirectdb = new sdirectdbContext();
            harshit = sdirectdb.Harshit17s.FirstOrDefault(h => h.Id == id);
            return harshit;

        }



        public string PostData(Harshit17 harshit)
        {
            sdirectdbContext sdirectdb = new sdirectdbContext();
            var data = sdirectdb.Harshit17s.Add(harshit);
            sdirectdb.SaveChanges();
            return ("working");
        }


        ///-------------------------UPdaTe-----------------------------------


        public bool Updatevalue(   Harshit17 harshit)
        {       
            sdirectdbContext sdirectdb = new sdirectdbContext();
            var data = sdirectdb.Harshit17s.FirstOrDefault(h => h.Id == harshit.Id);
            
            if (data.Id != null)
            {
               data.Name = harshit.Name;
                data.Dept=harshit.Dept;
                data.Salary= harshit.Salary;
                data.IsDeleted=harshit.IsDeleted;
                sdirectdb.SaveChanges();
                return true;
            }
            return false;
        }



        public ResponseModel Deletevalue(int Id)
        {
            ResponseModel response = new ResponseModel();
            sdirectdbContext sdirectdb = new sdirectdbContext();
           var data= sdirectdb.Harshit17s.FirstOrDefault(h => h.Id == Id && h.IsDeleted==false);
            if(data.Id!=null)
            {
                data.IsDeleted=true;
                sdirectdb.SaveChanges();
                response.Message = "User Delated Successfully";
                response.StatusCode = 200;
                response.ResponseId = data.Id;
                return response;
            }
            response.Message = "User Not exist in Database";
            response.StatusCode = 400;
         
            return response;

        }

    }

   public class ResponseModel
    {
        public string? Message { get; set; }
        public int StatusCode { get; set; }
         public int ResponseId { get; set; }
    }
}

