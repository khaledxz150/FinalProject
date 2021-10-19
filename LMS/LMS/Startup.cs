using First.Core.Common;
using First.Infra.Common;
using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Infra.Repository;
using LMS.Infra.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddScoped<IDbContext, DbContext>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<ILectureRepository, LectureRepository>();
            services.AddScoped<ILectureService, LectureService>();
            services.AddScoped<ILevelRepository, LevelRepository>();
            services.AddScoped<ILevelService, LevelService>(); 
            services.AddScoped<IOffLineLectureRepository, OffLineLectureRepository>();
            services.AddScoped<IOffLineLectureService, OffLineLectureService>();
            services.AddScoped<IExamOptionRepository, ExamOptionRepository>();
            services.AddScoped<IExamOptionService, ExamOptionService>();
            services.AddScoped<IExamQuestionRepository, ExamQuestionRepository>();
            services.AddScoped<IExamQuestionService, ExamQuestionService>();
            services.AddScoped<IRefundReasonRepository, RefundReasonRepository>();
            services.AddScoped<IRefundReasonService, RefundReasonService>();
            services.AddScoped<IContactUsRepository, ContactUsRepository>();
            services.AddScoped<IContactUsService, ContactUsService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LMS", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LMS v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
