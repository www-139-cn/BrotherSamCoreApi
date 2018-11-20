using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrotherSamCoreApi.Src.Const;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace BrotherSamCoreApi
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
            //begin 增加 为 Swagger 2018-11-19
            //注册Swagger生成器，定义一个和多个Swagger 文档
            services.AddSwaggerGen(c =>

            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "山哥的  API",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "山哥",
                        Email = string.Empty,
                        Url = "http://www.139.cn"
                    },
                    License = new License
                    {
                        Name = "许可证名字",
                        Url = "http://www.130.cn"
                    }
                });
            });
            //end 增加 为 Swagger 2018-11-19
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //begin 增加 为 Swagger 2018-11-19
            //启用中间件服务生成Swagger作为JSON终结点
            app.UseSwagger();
            //启用中间件服务对swagger-ui，指定Swagger JSON终结点
            app.UseSwaggerUI(c =>

            {

                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

            });
            //end 增加 为 Swagger 2018-11-19
            //通过读取"appsettings.json"文件，设定一些常量（包括数据库读取字符串）2018-11-18
            ReadJsonFile readJsonFile = new ReadJsonFile();
            readJsonFile.readJson("appsettings.json");
            //end 增加的
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
