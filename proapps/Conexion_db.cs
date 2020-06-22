using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria para trabajar con base de datos
using System.Data;
using System.Data.SqlClient;//libreria para conextar a una base de datos de SQL server

namespace proapps
{
    class Conexion_db
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public Conexion_db()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sistema_db.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();

           
            parametrizacion();
        }

        private void parametrizacion()
        {
            comandosSQL.Parameters.Add("@id", SqlDbType.Int).Value = 0;
            comandosSQL.Parameters.Add("@cod", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@nom", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@dir", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@tel", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@pag", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@cor", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@transporte", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@comida", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@vestimenta", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@ecenario", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@mar", SqlDbType.Char).Value = "";
            comandosSQL.Parameters.Add("@pre", SqlDbType.Char).Value = "";
        }


        public DataSet obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "clientes");

            comandosSQL.CommandText = "select * from empleados";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "empleados");


            comandosSQL.CommandText = "select * from gasto";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "gasto");

            comandosSQL.CommandText = "select * from eventos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "eventos");

            comandosSQL.CommandText = "select * from categorias";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "categorias");

            comandosSQL.CommandText = "select * from formas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "formas");

            comandosSQL.CommandText = "select * from informe";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "informe");

            comandosSQL.CommandText = "select * from deposito";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "deposito");

            comandosSQL.CommandText = "select * from tipopago";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "tipopago");

            comandosSQL.CommandText = "select categorias.categoria, eventos.idEvento, eventos.codigo, eventos.nombre, eventos.telefono, eventos.direccion, eventos.deposito from eventos inner join categorias on(categorias.idCategoria=eventos.idCategoria)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "eventos_categorias");

            comandosSQL.CommandText = "select formas.formas, informe.idInforme, informe.codigo, informe.nombre, informe.telefono, informe.correo from informe inner join formas on(formas.idforma=informe.idforma)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "informe_formas");

            comandosSQL.CommandText = "select tipopago.opciondepago, deposito.idDeposito, deposito.codigo, deposito.nombre, deposito.dui, deposito.total from deposito inner join tipopago on(tipopago.idTipopago=deposito.idTipopago)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "deposito_tipopago");

            return ds;
        }
        public void mantenimiento_datos_clientes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO clientes (codigo,nombre,direccion,telefono,pago) VALUES(@cod,@nom,@dir,@tel,@pag)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE clientes SET " +
                    "codigo         = @cod," +
                    "nombre         = @nom," +
                    "direccion      = @dir," +
                    "telefono       = @tel," +
                    "pago            = @pag " +
                    "WHERE idCliente = @id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE idCliente=@id";
            }
            comandosSQL.Parameters["@id"].Value = datos[0];
            if (accion != "eliminar")
            {
                comandosSQL.Parameters["@cod"].Value = datos[1];
                comandosSQL.Parameters["@nom"].Value = datos[2];
                comandosSQL.Parameters["@dir"].Value = datos[3];
                comandosSQL.Parameters["@tel"].Value = datos[4];
                comandosSQL.Parameters["@pag"].Value = datos[5];
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_empleados(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO empleados (codigo,nombre,telefono,correo,pagos) VALUES(@cod,@nom,@tel,@cor,@pag)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE empleados SET " +
                    "codigo        = @cod," +
                    "nombre        = @nom," +
                    "telefono      = @tel," +
                    "correo        = @cor," +
                    "pagos         = @pag " +
                    "WHERE idEmpleados = @id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE empleados FROM empleados WHERE idEmpleados=@id";
            }
            comandosSQL.Parameters["@id"].Value = datos[0];
            if (accion != "eliminar")
            {
                comandosSQL.Parameters["@cod"].Value = datos[1];
                comandosSQL.Parameters["@nom"].Value = datos[2];
                comandosSQL.Parameters["@tel"].Value = datos[3];
                comandosSQL.Parameters["@cor"].Value = datos[4];
                comandosSQL.Parameters["@pag"].Value = datos[5];
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_gasto(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO gasto (transporte,comida,vestimenta,ecenario) VALUES(@transporte,@comida,@vestimenta,@ecenario)";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE gasto SET " +
                    "transporte       = @transporte," +
                    "comida        = @comida," +
                    "estimenta      = @vestimenta," +
                    "ecenario        = @ecenario " +
                    "WHERE idGastos = @id";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE gasto FROM gasto WHERE idGastos=@id";
            }
            comandosSQL.Parameters["@id"].Value = datos[0];
            if (accion != "eliminar")
            {
                comandosSQL.Parameters["@transporte"].Value = datos[1];
                comandosSQL.Parameters["@comida"].Value = datos[2];
                comandosSQL.Parameters["@vestimenta"].Value = datos[3];
                comandosSQL.Parameters["@ecenario"].Value = datos[4];
            }
            procesarSQL(sql);
        }

        public void mantenimiento_datos_eventos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO eventos (idCategoria,codigo,nombre,telefono,direccion,deposito) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                     "'" + datos[5] + "'," +
                    "'" + datos[6] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE eventos SET " +
                    "idCategoria      = '" + datos[1] + "'," +
                    "codigo           = '" + datos[2] + "'," +
                    "nombre           = '" + datos[3] + "'," +
                    "telefono            = '" + datos[4] + "'," +
                    "direccion           = '" + datos[5] + "'," +
                    "deposito    = '" + datos[6] + "'" +
                    "WHERE idEvento   = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE eventos FROM eventos WHERE idEvento='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_informe(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO informe (idforma,codigo,nombre,telefono,correo) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE informe SET " +
                    "idforma         = '" + datos[1] + "'," +
                    "codigo         = '" + datos[2] + "'," +
                    "nombre      = '" + datos[3] + "'," +
                    "telefono      = '" + datos[4] + "'," +
                    "correo          = '" + datos[5] + "'" +
                    "WHERE idInforme = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE informe FROM informe WHERE idInforme='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_categorias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO categorias (categoria) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE categorias SET " +
                    "categoria            = '" + datos[1] + "'" +
                    "WHERE idCategoria = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE productos FROM categorias WHERE idCategoria='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        public void mantenimiento_datos_formas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO formas (formas) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE formas SET " +
                    "formas            = '" + datos[1] + "'" +
                    "WHERE idforma = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE informe FROM formas WHERE idforma='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        public void mantenimiento_datos_deposito(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO deposito (idTipopago,codigo,nombre,dui,total) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE deposito SET " +
                    "idTipopago     = '" + datos[1] + "'," +
                    "codigo           = '" + datos[2] + "'," +
                    "nombre           = '" + datos[3] + "'," +
                    "dui           = '" + datos[4] + "'," +
                    "total  = '" + datos[5] + "'" +
                    "WHERE idDeposito  = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE deposito FROM deposito WHERE idDeposito ='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        void procesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }


    }
}
