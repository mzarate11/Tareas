using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;



namespace BLL
{
    public class cls_Tarea6_BLL
    {
        public void Encriptar(ref cls_Tarea6_DAL Obj_DAL)
        {
            Encriptar_SR.IencriptarClient Obj_SVC = new Encriptar_SR.IencriptarClient();
            Obj_DAL.sResultado = Obj_SVC.Encript(Obj_DAL.sCadena, Obj_DAL.bEncript);
        }
        public void Desencriptar(ref cls_Tarea6_DAL Obj_DAL)
        {
            Desencriptar_SR.IdesencriptarClient Obj_SVC = new Desencriptar_SR.IdesencriptarClient();
            Obj_DAL.sResultado = Obj_SVC.desencript(Obj_DAL.sCadena, Obj_DAL.bEncript);
        }
        public void Fibonacci(ref cls_Tarea6_DAL Obj_DAL)
        {
            Fibonacci_SR.IfibonacciClient Obj_SVC = new Fibonacci_SR.IfibonacciClient();
            Obj_DAL.sResultadof = Obj_SVC.Fibo(Obj_DAL.iLimite, Obj_DAL.sResultadof);
        }

    }
}
