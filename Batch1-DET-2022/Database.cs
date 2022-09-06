using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch1_DET_2022.EmployeeLinq;

namespace Batch1_DET_2022
{
    public class DatabaseFirstApproach
    {
        public static void Main()
        {
            CallStoredProcwithSQLParamater_insert();
            //GetAllEmpDetails();
            //GetEmpDetailsByID();
            //AddNewEmployee();
            //DeleteEmployee();
            //UpdateEmployee();
            //GetEmployeeSP();
            //GetEmployeeSalWithParameterSP();
            //Console.ReadLine();
            //UpdateEmployeeNameSP();
        }

        //private static void UpdateEmployee()
        //{
        //    var ctx = new trainingContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 2979;
        //        employee.Ename = "Mary";
        //        employee.Sal = 2000;
        //        employee.Deptno = 30;
        //        employee.Job = "Trainer";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New employee updated");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
            //private static void DeleteEmployee()
            //{

            //    var ctx = new trainingContext();

            //    try
            //    {
            //        Emp employee = new Emp();
            //        employee.Empno = 2979;
            //        employee.Ename = "Sheela";
            //        employee.Sal = 1000;
            //        employee.Deptno = 30;
            //        employee.Job = "Trainer";
            //        ctx.Remove(employee);
            //        ctx.SaveChanges();
            //        Console.WriteLine("New employee deleted");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.InnerException.Message);
            //    }


            //}
            // public static void AddNewEmployee()
            //{
            //    var ctx = new trainingContext();

            //    try
            //    {
            //        Emp employee = new Emp();
            //        employee.Empno = 2979;
            //        employee.Ename = "Sheela";
            //        employee.Sal = 1000;
            //        employee.Deptno = 30;
            //        employee.Job = "Trainer";
            //        ctx.Add(employee);
            //        ctx.SaveChanges();
            //        Console.WriteLine("New employee added");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.InnerException.Message);
            //    }
            //}

        //private static void GetEmployeesSP()
        //{
        //    var ctx = new trainingContext();
        //    try
        //    {

        //        var employees = ctx.Emps.FromSqlRaw("employee");
        //        foreach (var e in employees)
        //        {
        //            Console.WriteLine(e.Ename);
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void GetEmployeeSalWithParameterSP()
        //{
        //    var ctx = new trainingContext();
        //    try
        //    {
        //        var employees = ctx.Emp.FromSqlRaw("empno  @p0", 7521);
        //        foreach (var e in employees)
        //        {
        //            Console.WriteLine(e.Sal);
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }

        //}

        //private static void UpdateEmployeeNameSP()
        //{
        //    var ctx = new trainingContext();
        //    try
        //    {
        //        var val = 2979;
        //        string name = "Roja";
        //        var employees = ctx.Database.ExecuteSqlRaw("updatempname @p0,@p1", val,name);
        //        Console.WriteLine(employees);
                
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }

        //}

        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new trainingContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 2977
                        },

                         new SqlParameter() {
                            ParameterName = "@epname",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Priya"},

                          new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Salesman"},

                          new SqlParameter() {
                            ParameterName = "@mgr",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "7698"},

                           new SqlParameter() {
                            ParameterName = "@hiredate",
                            SqlDbType =  System.Data.
                            SqlDbType.Date,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "09/05/2022"},

                            new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30000},

                             new SqlParameter() {
                            ParameterName = "@comm",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 20},

                              new SqlParameter() {
                            ParameterName = "@deptno",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 10},

                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("insertempval @empno, @epname, @job, @mgr, @hiredate, @sal, @comm, @deptno", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }



        private static void InsertEmployeeDetails()
        {
            var ctx = new trainingContext();
            try
            {
                var empno = 2345;
                string name = "Manasa";
                string job = "Analyst";
                var mgr = 7839;
                var hiredate = "09/06/2022";
                var sal = 40000;
                var comm = 200;
                var deptno = 20;
               
                var employees = ctx.Database.ExecuteSqlRaw("insertempval @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7", empno, name,job,mgr,hiredate,sal,comm,deptno);
                Console.WriteLine(employees);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

        }
        }



        //private static void GetEmpDetailsByID()
        //{
        //    var ctx = new trainingContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7521).SingleOrDefault();
        //    Console.WriteLine(emp.Ename + " " + emp.Sal + " " + emp.Job);
        //}

        //private static void GetAllEmpDetails()
        //{
        //    var ctx = new trainingContext();
        //    var emps = ctx.Emps;
        //    foreach(var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename + " " + emp.Sal);
        //    }
        //}
    }


