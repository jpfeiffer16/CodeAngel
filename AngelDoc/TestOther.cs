using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AngelDoc
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITestInterfaceOther
    {
        string TestMethod(int id);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AngelDoc.ITestInterface" />
    [ExcludeFromCodeCoverage]
    public class TestClassOther : ITestInterfaceOther
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestClassOther"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="dateTime">The date time.</param>
        public TestClassOther(int id, string name, DateTime dateTime)
        {

        }

        /// <summary>
        /// Gets the stuff.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public List<string> GetStuff(int id, string name)
        {
            return new List<string>();
        }

        /// <summary>
        /// Sets a thing.
        /// </summary>
        private static void SetAThing()
        {
            //Do a thing
        }

        // TODO: Here we should insert <inheritdoc cref="..."/>
        /// <summary>
        /// Tests the method.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string TestMethod(int id)
        {
            return "123";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class TestProgramClassOther
    {
        /// <summary>
        /// Tests the main.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void TestMain(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Parses the text.
        /// </summary>
        /// <returns></returns>
        static string ParseText()
        {
            return "";
        }

        /// <summary>
        /// Determines whether [is a thing].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is a thing]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAThing()
        {
            return false;
        }

        /// <summary>
        /// Shoulds the do a thing.
        /// </summary>
        /// <returns></returns>
        public bool ShouldDoAThing()
        {
            return true;
        }

        /// <summary>
        /// Gets the identifier list.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public List<string> GetIdList(string name)
        {
            return new List<string>();
        }

        /// <summary>
        /// Gets a value indicating whether [access limit].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [access limit]; otherwise, <c>false</c>.
        /// </value>
        public bool AccessLimit { get; }

        /// <summary>
        /// Gets or sets a value indicating whether [should enable a thing].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [should enable a thing]; otherwise, <c>false</c>.
        /// </value>
        public bool ShouldEnableAThing { get; set; }

        /// <summary>
        /// Gets a value indicating whether [should enable feature one].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [should enable feature one]; otherwise, <c>false</c>.
        /// </value>
        public bool ShouldEnableFeatureOne { get; }

        /// <summary>
        /// The number field
        /// </summary>
        public readonly int NumberField = 123;

        /// <summary>
        /// 
        /// </summary>
        public enum TestEnum
        {
            ONE = 1,
            TWO = 2
        }

        /// <summary>
        /// 
        /// </summary>
        [ExcludeFromCodeCoverage]
        public struct TestStruct
        {
            /// <summary>
            /// Gets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; }

            /// <summary>
            /// Initializes a new instance of the <see cref="TestStruct"/> struct.
            /// </summary>
            /// <param name="id">The identifier.</param>
            /// <param name="name">The name.</param>
            /// <exception cref="NotImplementedException"></exception>
            public TestStruct(int id, string name)
            {
                Name = name ?? throw new NotImplementedException();
            }

            /// <summary>
            /// Stuffs the specified identifier.
            /// </summary>
            /// <param name="id">The identifier.</param>
            public void Stuff(int id)
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TStuff">The type of the stuff.</typeparam>
        [ExcludeFromCodeCoverage]
        public class GenericClass<TStuff>
        {
            /// <summary>
            /// Gets the t stuff.
            /// </summary>
            /// <typeparam name="TThing">The type of the thing.</typeparam>
            /// <param name="id">The identifier.</param>
            /// <returns></returns>
            public TThing GetTStuff<TThing>(int id)
            {
                return default(TThing);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface ITestGenericInterface<T>
        { }
    }
}
