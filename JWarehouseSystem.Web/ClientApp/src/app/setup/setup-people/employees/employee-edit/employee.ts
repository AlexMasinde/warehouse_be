export class Employee {
  constructor(
        public id:number,
        public FirstName:string,
        public LastName: string,
        public Identity: string,
        public  Telephone: string,
        public  Email: string,
        public Photo: any,
        public  Number: string,
        public  Department: string,
        public  Designation: string,
        public  CreatedByID : number,
        public  CreatedBy : any,
        public  CreateOn : Date,
        public  ModifiedByID : number,
        public  ModifiedBy : any,
        public  ModifiedOn : Date,

  ) { }
}
