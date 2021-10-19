using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LMS.Data
{
    public partial class LMSContext : DbContext
    {
        public LMSContext()
        {
        }

        public LMSContext(DbContextOptions<LMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseRating> CourseRatings { get; set; }
        public virtual DbSet<CourseRefund> CourseRefunds { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<EvalouationAnswer> EvalouationAnswers { get; set; }
        public virtual DbSet<EvalouationQusetion> EvalouationQusetions { get; set; }
        public virtual DbSet<Evaluation> Evaluations { get; set; }
        public virtual DbSet<EvaluationFormsAnswer> EvaluationFormsAnswers { get; set; }
        public virtual DbSet<EvaluationFormsQuestion> EvaluationFormsQuestions { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamOption> ExamOptions { get; set; }
        public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<OffLineLecture> OffLineLectures { get; set; }
        public virtual DbSet<RefundReason> RefundReasons { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<TraineeAttendance> TraineeAttendances { get; set; }
        public virtual DbSet<TraineeBuyCourse> TraineeBuyCourses { get; set; }
        public virtual DbSet<TraineeSection> TraineeSections { get; set; }
        public virtual DbSet<TraineeSectionExam> TraineeSectionExams { get; set; }
        public virtual DbSet<TraineeSectionTask> TraineeSectionTasks { get; set; }
        public virtual DbSet<TrainerSection> TrainerSections { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<WishList> WishLists { get; set; }
        public virtual DbSet<WishListItem> WishListItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-H6F4JP9\\SQLEXPRESS;Database=LMS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_Cart_Trainee");
            });

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.ToTable("CartItem");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.CartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartItem_Cart");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartItem_Section");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Category_Employee");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Comment_Course");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Trainee");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Comment_Section1");
            });

            modelBuilder.Entity<ContactU>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_Massages");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(14)
                    .HasColumnName("phoneNumber");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.ContactUs)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_ContactUs_Trainee");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("Coupon");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Coupon_Course");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupon_Employee");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");

                entity.Property(e => e.CoursePrice).HasColumnType("numeric(10, 3)");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(550);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.PreviewVideoUrl).HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Course_Category");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_Employee");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK_Course_Level");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_Course_Tag");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Course_Status");
            });

            modelBuilder.Entity<CourseRating>(entity =>
            {
                entity.ToTable("CourseRating");

                entity.Property(e => e.RateNote).HasMaxLength(30);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.CourseRatings)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CourseRating_Section");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.CourseRatings)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CourseRating_Trainee");
            });

            modelBuilder.Entity<CourseRefund>(entity =>
            {
                entity.HasKey(e => e.CourseRefundsId);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.RefundsNotes).HasMaxLength(250);

                entity.HasOne(d => d.ApprovedEmployee)
                    .WithMany(p => p.CourseRefunds)
                    .HasForeignKey(d => d.ApprovedEmployeeId)
                    .HasConstraintName("FK_CourseRefunds_CourseRefunds1");

                entity.HasOne(d => d.RefundsReasons)
                    .WithMany(p => p.CourseRefunds)
                    .HasForeignKey(d => d.RefundsReasonsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CourseRefunds_Reason");

                entity.HasOne(d => d.TraineeByCourse)
                    .WithMany(p => p.CourseRefunds)
                    .HasForeignKey(d => d.TraineeByCourseId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CourseRefunds_TraineeBuyCourse");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.NationalSecurutiyNumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.RoleType)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.RoleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_LoginType");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATION_DATE");

                entity.Property(e => e.ErrorLine).HasColumnName("ERROR_LINE");

                entity.Property(e => e.ErrorMessage).HasColumnName("ERROR_MESSAGE");

                entity.Property(e => e.ErrorNumber).HasColumnName("ERROR_NUMBER");

                entity.Property(e => e.ErrorProcedure).HasColumnName("ERROR_PROCEDURE");

                entity.Property(e => e.ErrorSeverity).HasColumnName("ERROR_SEVERITY");

                entity.Property(e => e.ErrorState).HasColumnName("ERROR_STATE");
            });

            modelBuilder.Entity<EvalouationAnswer>(entity =>
            {
                entity.ToTable("EvalouationAnswer");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EvalouationAnswers)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_EvalouationAnswer_Employee");

                entity.HasOne(d => d.EvalouationQuestion)
                    .WithMany(p => p.EvalouationAnswers)
                    .HasForeignKey(d => d.EvalouationQuestionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EvalouationAnswer_EvalouationAnswer");
            });

            modelBuilder.Entity<EvalouationQusetion>(entity =>
            {
                entity.ToTable("EvalouationQusetion");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Descrition)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EvalouationQusetions)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EvalouationQusetion_Employee");
            });

            modelBuilder.Entity<Evaluation>(entity =>
            {
                entity.ToTable("Evaluation");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Evaluations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Evaluation_Employee");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Evaluations)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Evaluation_Section");
            });

            modelBuilder.Entity<EvaluationFormsAnswer>(entity =>
            {
                entity.HasKey(e => e.EvaluationFormsAnswersId);

                entity.Property(e => e.EvaluationFormsAnswersId).HasColumnName("EvaluationFormsAnswersID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.EvaluationAnswer)
                    .WithMany(p => p.EvaluationFormsAnswers)
                    .HasForeignKey(d => d.EvaluationAnswerId)
                    .HasConstraintName("FK_EvaluationFormsAnswers_EvalouationAnswer");

                entity.HasOne(d => d.Evaluation)
                    .WithMany(p => p.EvaluationFormsAnswers)
                    .HasForeignKey(d => d.EvaluationId)
                    .HasConstraintName("FK_EvaluationFormsAnswers_Evaluation");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.EvaluationFormsAnswers)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_EvaluationFormsAnswers_Trainee");
            });

            modelBuilder.Entity<EvaluationFormsQuestion>(entity =>
            {
                entity.ToTable("EvaluationFormsQuestion");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EvaluationFormsQuestions)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EvaluationFormsQuestion_Employee");

                entity.HasOne(d => d.Evaluation)
                    .WithMany(p => p.EvaluationFormsQuestions)
                    .HasForeignKey(d => d.EvaluationId)
                    .HasConstraintName("FK_EvaluationFormsQuestion_Evaluation");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.EvaluationFormsQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_EvaluationFormsQuestion_EvalouationQusetion");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.ToTable("Exam");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExamDate).HasColumnType("date");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_Employee");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_Section");
            });

            modelBuilder.Entity<ExamOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PK_Option");

                entity.ToTable("ExamOption");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ExamOptions)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamOption_Employee");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ExamOptions)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Option_Question");
            });

            modelBuilder.Entity<ExamQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK_Question");

                entity.ToTable("ExamQuestion");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ImageName).IsUnicode(false);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.ExamQuestions)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Question_Course");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ExamQuestions)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Employee");
            });

            modelBuilder.Entity<Lecture>(entity =>
            {
                entity.ToTable("Lecture");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Lectures)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lecture_Employee");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Lectures)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Lecture_Section");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.ToTable("Level");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Levels)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Level_Employee");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.HasIndex(e => e.Username, "UQ__Login__536C85E4277B3F1A")
                    .IsUnique();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Login_Employee");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Login_Trainee");
            });

            modelBuilder.Entity<OffLineLecture>(entity =>
            {
                entity.ToTable("OffLineLecture");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.VideoUrl)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.OffLineLectures)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_OffLineLecture_Course");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OffLineLectures)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffLineLecture_Employee");
            });

            modelBuilder.Entity<RefundReason>(entity =>
            {
                entity.HasKey(e => e.ReasonId)
                    .HasName("PK_Reason");

                entity.ToTable("RefundReason");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonDescription)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleType>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_LoginType");

                entity.ToTable("RoleType");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Section");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tag_Employee");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deadline).HasColumnType("datetime");

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mark).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Employee");

                entity.HasOne(d => d.SectionTrainer)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.SectionTrainerId)
                    .HasConstraintName("FK_Task_TrainerCourse");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.HasKey(e => e.TestimonialsId);

                entity.Property(e => e.TestimonialsId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.HasOne(d => d.ApprovedEmployee)
                    .WithMany(p => p.TestimonialApprovedEmployees)
                    .HasForeignKey(d => d.ApprovedEmployeeId)
                    .HasConstraintName("FK_Testimonials_Testimonials");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TestimonialCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Testimonials_Employee");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TopicName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Topics)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Topic_Course");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Topics)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Topic_Employee");
            });

            modelBuilder.Entity<Trainee>(entity =>
            {
                entity.ToTable("Trainee");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Trainees)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Trainee_Employee");
            });

            modelBuilder.Entity<TraineeAttendance>(entity =>
            {
                entity.ToTable("TraineeAttendance");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TraineeAttendances)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeAttendance_Employee");

                entity.HasOne(d => d.TraineeSection)
                    .WithMany(p => p.TraineeAttendances)
                    .HasForeignKey(d => d.TraineeSectionId)
                    .HasConstraintName("FK_TraineeAttendance_TraineeSection");
            });

            modelBuilder.Entity<TraineeBuyCourse>(entity =>
            {
                entity.ToTable("TraineeBuyCourse");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.TraineeBuyCourses)
                    .HasForeignKey(d => d.CouponId)
                    .HasConstraintName("FK_TraineeBuyCourse_Coupon");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TraineeBuyCourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_TraineeBuyCourse_Course");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeBuyCourses)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_TraineeBuyCourse_Trainee");
            });

            modelBuilder.Entity<TraineeSection>(entity =>
            {
                entity.ToTable("TraineeSection");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.TotalMark).HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TraineeSections)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_TraineeSection_Employee");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.TraineeSections)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_TraineeCourse_Section");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TraineeSections)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_TraineeCourse_Trainee");
            });

            modelBuilder.Entity<TraineeSectionExam>(entity =>
            {
                entity.ToTable("TraineeSectionExam");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Mark).HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TraineeSectionExams)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeSectionExam_Employee");

                entity.HasOne(d => d.TraineeSection)
                    .WithMany(p => p.TraineeSectionExams)
                    .HasForeignKey(d => d.TraineeSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeSectionExam_TraineeSection");
            });

            modelBuilder.Entity<TraineeSectionTask>(entity =>
            {
                entity.ToTable("TraineeSectionTask");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mark).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TraineeSectionTasks)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeSectionTask_Task");

                entity.HasOne(d => d.TraineeSection)
                    .WithMany(p => p.TraineeSectionTasks)
                    .HasForeignKey(d => d.TraineeSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraineeSectionTask_TraineeSection");
            });

            modelBuilder.Entity<TrainerSection>(entity =>
            {
                entity.ToTable("TrainerSection");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TrainerSectionCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_TrainerSection_Employee");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.TrainerSectionTrainers)
                    .HasForeignKey(d => d.TrainerId)
                    .HasConstraintName("FK_TrainerCourse_Employee");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Types)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Type_Employee");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Unit_Employee");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Unit_Section");
            });

            modelBuilder.Entity<WishList>(entity =>
            {
                entity.ToTable("WishList");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.WishLists)
                    .HasForeignKey(d => d.TraineeId)
                    .HasConstraintName("FK_wishlist_Trainee");
            });

            modelBuilder.Entity<WishListItem>(entity =>
            {
                entity.ToTable("WishListItem");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.WishListItems)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WishListItem_Course");

                entity.HasOne(d => d.WishList)
                    .WithMany(p => p.WishListItems)
                    .HasForeignKey(d => d.WishListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WishListItem_wishlist");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
