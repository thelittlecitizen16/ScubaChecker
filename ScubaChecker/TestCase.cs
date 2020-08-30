using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScubaChecker
{
    [Serializable()]
    public class TestCase : ITestCase
    {
        public string TestContent  { get; set ; }
        public int Id { get ; set; }
        public TestCase()
        {

        }
        public TestCase(string testContent, int id)
        {
            TestContent = testContent;
            Id = id;
        }
        public bool Run()
        {
            return true;
        }
        
    }
}
