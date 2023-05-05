namespace thirdapi.repository3
{
    public interface Empoyee_Interface
    {

        //--------------------------GET-----------------------------------------//

        public List<Harshit17> Get_Data();

        public Harshit17 Getbyid(int id);
      


        //--------------------------POST---------------------------------------------//
        public string PostData(Harshit17 harshit);
       

   

       //public List<Harshit17 > GetbyidAll(int id);
        //------------------------------------UPDATE-----------------------------------------//
        public bool Updatevalue(Harshit17 harshit);



        //------------------------------------DELETE-------------------------------------//
        public ResponseModel Deletevalue(int id);

        
    }
}
