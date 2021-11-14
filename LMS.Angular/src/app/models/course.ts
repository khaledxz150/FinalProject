export class Course{
  courseId:number = 0;
  courseName:string |undefined;
  courseDescription:string |undefined;
  passMark:number |undefined;
  coursePrice:number |undefined;
  image:string |undefined;
  typeId:number |undefined;
  levelId:number |undefined;
  categoryId:number |undefined;
  previewVideoUrl:string |undefined;
  tagId:number |undefined;
  tagName:string |undefined;
  levelName:string |undefined;
  categoryName:string |undefined;
  typeName:string | undefined
}


export class Coupon{
  couponId:number = 0;
  courseId:number|undefined;
  code:string|undefined;
  discount:number|undefined;
  redemption:number|undefined;
  startDate:string=''
  endDate:string=''
  courseName:string|undefined;
  courseImage:string|undefined;
  coursePrice:number|undefined;
  currentPrice:number|undefined;
  isActive:boolean|undefined
}


/**        public int CouponId { get; set; }
        public int CourseId { get; set; }
        public decimal? Discount { get; set; }
        public int? Redemption { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CourseName { get; set; }
        public decimal CoursePrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public string CourseImage { get; set; }
         */


        export class SoldCourse{
          checkoutId:number = 0;
          cartId:number|undefined;
          cartItemId:number|undefined;
          courseId:number|undefined;
          creationDate:string = '';
          courseName:string|undefined;
          firstName:string|undefined;
          lastName:string|undefined;
          traineeImage:string|undefined;
          phoneNumber:number|undefined;
          coursePrice:number = 0;
        }
