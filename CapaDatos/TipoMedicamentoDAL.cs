using CapaEntidad;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace CapaDatos
{
    public class TipoMedicamentoDAL
    {

        //public List<TipoMedicamentoCLS> listarMedicamentos()
        //{
        //    List<TipoMedicamentoCLS> lista = new List<TipoMedicamentoCLS>();
        //    lista.Add(new TipoMedicamentoCLS()
        //    {
        //        idtipomedicamento = 1,
        //        nombre = "Analgesicos",
        //        descripcion = "Des 1"
        //    });
        //    lista.Add(new TipoMedicamentoCLS()
        //    {
        //        idtipomedicamento = 2,
        //        nombre = "Antialegrivco",
        //        descripcion = "Des 2"
        //    });
        //    return lista;
        //}

        public List<TipoMedicamentoCLS> listarMedicamentos()
        {
            List<TipoMedicamentoCLS> lista = null;

            IConfigurationBuilder builder = new ConfigurationBuilder();

            builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
            var root = builder.Build();
            var cadenaDato = root.GetConnectionString("cn");
            using (SqlConnection cn = new SqlConnection(cadenaDato))
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select IIDTIPOMEDICAMENTO,NOMBRE,DESCRIPCION from TipoMedicamento where BHABILITADO = 1", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        //Ejecuto la consulta
                        SqlDataReader drd = cmd.ExecuteReader();
                        if (drd != null)
                        {
                            TipoMedicamentoCLS oTipoMedicamentoCLS;
                            lista = new List<TipoMedicamentoCLS>();
                            //Leemos fila por fila
                            while (drd.Read())
                            {
                                oTipoMedicamentoCLS = new TipoMedicamentoCLS();
                                oTipoMedicamentoCLS.idtipomedicamento = drd.GetInt32(0);
                                oTipoMedicamentoCLS.nombre = drd.GetString(1);
                                oTipoMedicamentoCLS.descripcion = drd.GetString(2);
                                lista.Add(oTipoMedicamentoCLS);
                            }
                            //Cuando terminamos de llenar tenemos que cerrar la conexion
                            cn.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    lista = null;
                }
            }
            return lista;
        }
    }
}
