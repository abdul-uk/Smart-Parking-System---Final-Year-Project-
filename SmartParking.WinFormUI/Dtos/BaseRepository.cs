using Bunifu.Json;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParking.WinFormUI
{
    public class BaseRepository<Tk, Tv>
    {
        /// <summary>
        /// The logger.
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(typeof(BaseRepository<Tk, Tv>));

        /// <summary>
        /// The file access lock
        /// </summary>
        private readonly object fileAccessLock;

        /// <summary>
        /// The filename.
        /// </summary>
        private readonly string filename;

        /// <summary>
        /// True if calls to WriteDictionary are actually written to disk, false otherwise.
        /// Allows transactions to be implemented, specifically for optimum performance of bulk updates.
        /// </summary>
        private bool writePermitted;

        /// <summary>
        /// The dictionary definition for the repository.
        /// </summary>
        private Dictionary<Tk, Tv> dictionary;

        public BaseRepository(string filename)
        {
            this.writePermitted = true;
            this.fileAccessLock = new object();
            this.filename = filename;
            this.dictionary = new Dictionary<Tk, Tv>();
            //this.ReadDictionaryFromDisk();
        }

        /// <summary>
        /// Gets the file access.
        /// </summary>
        /// <value>
        /// The file access.
        /// </value>
        public object FileAccess
        {
            get { return this.fileAccessLock; }
        }

        /// <summary>
        /// Saves the specified record.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Add(Tk key, Tv value)
        {
            if (key == null)
            {
                return;
            }

            this.dictionary[key] = value;
        }

        /// <summary>
        /// Removes the specified record.
        /// </summary>
        /// <param name="key">The key.</param>
        public virtual void Remove(Tk key)
        {
            if (key == null)
            {
                return;
            }

            this.dictionary.Remove(key);
        }

        /// <summary>
        /// Removes all records.
        /// </summary>
        public virtual void RemoveAll()
        {
            this.dictionary.Clear();
        }

        /// <summary>
        /// Gets the record from the repository with the specified key.
        /// </summary>
        /// <param name="key">The key of record desired.</param>
        /// <param name="value">The value of the record.</param>
        /// <returns>True if the record was found, false otherwise.</returns>
        public bool GetById(Tk key, out Tv value)
        {
            return this.dictionary.TryGetValue(key, out value);
        }

        /// <summary>
        /// Gets all of records in the repository.
        /// </summary>
        /// <returns>A list containing all of the records.</returns>
        public IList<Tv> GetAll()
        {
            return this.dictionary.Values.ToList();
        }

        /// <summary>
        /// Gets all of keys in the repository.
        /// </summary>
        /// <returns>A list containing all of the repository keys.</returns>
        public IList<Tk> GetKeys()
        {
            return this.dictionary.Keys.ToList();
        }

        /// <summary>
        /// Writes the dictionary to disk.
        /// </summary>
        public void WriteDictionaryToDisk()
        {
            if (!this.writePermitted)
            {
                return;
            }

            try
            {
                System.IO.File.AppendAllText(this.filename, JsonConvert.SerializeObject(this.dictionary.Values.ToList()));
            }
            catch (Exception e)
            {
                if (Log.IsErrorEnabled)
                {
                    Log.Error($"Failed to write {this.filename} to disk.");
                    Log.Error($"Exception: {e}");
                }
            }
        }

        /// <summary>
        /// Gets the dictionary.
        /// </summary>
        /// <returns>The dictionary</returns>
        protected Dictionary<Tk, Tv> GetDictionary()
        {
            return this.dictionary;
        }

        /// <summary>
        /// Puts the repository into a Mode whereby calls to Add will be written to disk.
        /// This is primarily for the file-based implementation to allow faster startup time with full set
        /// of test data.
        /// Should call DisableWriting, followed by 1000's of calls to Add, finally followed with a call to EnableWriting.
        /// </summary>
        protected void EnableWriting()
        {
            this.writePermitted = true;
            this.WriteDictionaryToDisk();
        }

        /// <summary>
        /// Puts the repository into a Mode whereby calls to Add will not be written to disk.
        /// This is primarily for the file-based implementation to allow faster startup time with full set
        /// of test data.
        /// </summary>
        protected virtual void DisableWriting()
        {
            this.writePermitted = false;
        }

        /// <summary>
        /// Reads the dictionary from disk.
        /// </summary>
        private void ReadDictionaryFromDisk()
        {
            try
            {
                string json = System.IO.File.ReadAllText(this.filename);
                this.dictionary = JsonConvert.DeserializeObject<Dictionary<Tk, Tv>>(json);
            }
            catch (Exception)
            {
                // not really a problem, we just startup with an empty dictionary if the file isn't there
                if (Log.IsInfoEnabled)
                {
                    Log.Info($"Failed to read {this.filename} on startup, initialising with empty repository.");
                }
            }
        }

    }
}
