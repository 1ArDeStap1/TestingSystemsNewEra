using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Tester
{
    internal class SerializerXML
    {


        private class Datafile
        {

            public string dtName { get; set; }
            public DataTable dr { get; set; }

        }

        public void SaveToXML(DataSet dts, DataTable[] dtArray, string FilePath = "")
        {
            using (XmlWriter writer = XmlWriter.Create(FilePath + @"/" + "Export"  + DateTime.Now.ToString("yyyyMMddHHmmss")))
            {
                writer.WriteStartDocument();
                writer.WriteWhitespace("\r\n");
                writer.WriteStartElement(dts.DataSetName);
                writer.WriteAttributeString("namespace", dts.Namespace);
                foreach (DataTable dt in dtArray)
                {
                    writer.WriteWhitespace("\r\n\t");
                    writer.WriteStartElement(dt.TableName);
                    foreach (DataRow dtr in dt.Rows)
                    {
                        writer.WriteWhitespace("\r\n\t\t");
                        writer.WriteStartElement(dt.TableName + "Row");
                        writer.WriteAttributeString("id", dtr[0].ToString());
                        for (int i = 0; i < dtr.Table.Columns.Count; i++) {
                            writer.WriteWhitespace("\r\n\t\t\t");
                            if (dtr.Table.Columns[i].ColumnName == "image")
                            {
                                string ImgArray = Convert.ToBase64String((System.Byte[])dtr[i]);
                                XElement element = new XElement(dtr.Table.Columns[i].ColumnName, ImgArray);
                                element.WriteTo(writer);
                            }
                            else
                            {
                                XElement element = new XElement(dtr.Table.Columns[i].ColumnName, dtr[i].ToString());
                                element.WriteTo(writer);
                            }
                        }
                        writer.WriteWhitespace("\r\n\t\t");
                        writer.WriteEndElement();
                    }
                    writer.WriteWhitespace("\r\n\t");
                    writer.WriteEndElement();
                }
                writer.WriteWhitespace("\r\n");
                writer.WriteEndElement();
                /*writer.WriteEndElement();*/
                writer.WriteEndDocument();
            }
        }


        IEnumerable<List<Datafile>> GetXMLTablesStructure(string FilePath, DataSet ds)
        {
            using (var reader = XmlReader.Create(FilePath))
            {
                var DataFiles = new List<Datafile>();
                bool flag = false;
                bool needToRead = false;
                DataTable dtTemp = new DataTable();
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (!needToRead)
                        {
                            if (reader.Name == ds.DataSetName)
                            {
                                needToRead = true;
                            } else { yield return null; break; }
                        }
                        if (flag)
                        {

                            if (reader.Name == dtTemp.TableName + "Row")
                            {

                                DataRow dtr = dtTemp.NewRow();
                                foreach (DataColumn dr in dtTemp.Columns)
                                {
                                    reader.ReadToFollowing(dr.ColumnName);
                                    if (dr.ColumnName == "image")
                                    {
                                        dtr[dr.ColumnName] = Convert.FromBase64String(reader.ReadElementContentAsString());
                                    }
                                    else
                                    {
                                        dtr[dr.ColumnName] = reader.ReadElementContentAsString();
                                    }
                                }
                                dtTemp.Rows.Add(dtr);
                                

                                if (dtTemp.Rows.Count % 50 == 0)
                                {
                                    var dataFile = new Datafile();
                                    dataFile.dtName = dtTemp.TableName;
                                    dataFile.dr = dtTemp;
                                    DataFiles.Add(dataFile);
                                    yield return DataFiles;
                                    DataFiles = new List<Datafile>();
                                }
                            }
                        }
                        else
                        {
                            foreach (DataTable dt in ds.Tables)
                            {
                                if (dt.TableName == reader.Name)
                                {
                                    dtTemp = dt.Clone();
                                    flag = true;
                                    break;
                                }

                            }
                        } 

                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        if (reader.Name == dtTemp.TableName)
                        {
                            if (dtTemp.Rows.Count > 0)
                            {
                                var dataFile = new Datafile();
                                dataFile.dtName = dtTemp.TableName;
                                dataFile.dr = dtTemp;
                                DataFiles.Add(dataFile);
                            }
                            flag = false;
                        }
                    }

                }

                if (DataFiles.Count > 0)
                    yield return DataFiles;

            }
            
        }


        public List<DataTable> ImportFromXML(DataSet dts, string FilePath)
        {

            DataTable dt = new DataTable();
            List<DataTable> dtList = new List<DataTable>();
            foreach (var files in GetXMLTablesStructure(FilePath, dts))
            {
                if (files == null)
                    return null;
                foreach (var file in files)
                {
                    if (dt.TableName != file.dtName)
                    {
                        if (dt.TableName != "")
                        {
                            dtList.Add(dt);
                            dt = file.dr.Copy();   
                        }
                        else
                        {
                            dt = file.dr.Copy();
                        }

                    }
                    else
                    {
                        dt.Merge(file.dr);
                        
                    }
                }
            }
            dtList.Add(dt);

            return dtList;
        }

    }
}
