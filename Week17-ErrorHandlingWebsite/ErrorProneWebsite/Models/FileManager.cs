﻿using System;
using System.IO;

namespace ErrorProneWebsite.Models
{
    public class FileManager
    {
        private string _contentFilePath;

        public FileManager(string contentFilePath)
        {
            // TODO: Complete member initialization
            this._contentFilePath = contentFilePath;
        }

        /// <summary>
        /// <para>Reads a file from the _contentFilePath and returns the contents.</para>
        /// <para>What sort of things could go wrong? There's quite a few!</para>
        /// <para>In fact, there's already a big, fat error in this code that needs fixing, never mind all the other things that could happen...</para>
        /// <para>So at the very least some error handling needs to happen here...</para>
        /// </summary>
        /// <returns>The contents of the file from the file path as a string.</returns>
        /// Hello World

        public string GetContent()
        {
            string contentMessage = String.Empty;
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(_contentFilePath);
                contentMessage = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                contentMessage = String.Format("{0}{1}{2}",
                    "Blimey! Something totally unexpected just happened",
                    Environment.NewLine,
                    ex.Message

                    );               
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
            }
            return contentMessage;  
            

            
        }
    }
}