﻿using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocios
{
    public class EmpleadoBO
    {
        public EmpleadoBO()
        {

        }
        public CEmpleados ObtenerDatosVendedor(int iVendedor)
        {
            CEmpleados objCEmpleados = new CEmpleados();
            EmpleadoDAL objEmpleadoDAL = new EmpleadoDAL();
            objCEmpleados = objEmpleadoDAL.ObtenerDatosVendedor(iVendedor);
            return objCEmpleados;
        }

        public Double ObtenerInvVendedorArticulo(int iEmpleadoID, int iCodigoArticulo)
        {
            EmpleadoDAL objArticuloDAL = new EmpleadoDAL();
            return objArticuloDAL.ObtenerInvVendedorArticulo(iEmpleadoID, iCodigoArticulo);

        }
    }
}
