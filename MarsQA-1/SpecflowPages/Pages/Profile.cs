using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Profile
    {
        public IWebDriver WebDriver { get; }
        
         //Click languagetab
        public IWebElement ClkLangTab => WebDriver.FindElement(By.LinkText("Languages"));
        //click add new btn
        public IWebElement Addnewbtn => WebDriver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment active tooltip-target'] div[class='ui teal button ']"));
        //enter language
        public IWebElement AddLanguage => WebDriver.FindElement(By.CssSelector("input[placeholder='Add Language']"));
        //select level for languages 
        public IWebElement SelectLevel => WebDriver.FindElement(By.CssSelector("select[name='level']"));
        // click add button to add enterd languages
        public IWebElement BtnADD => WebDriver.FindElement(By.CssSelector("input[value='Add']"));
        //click edit button
        public IWebElement Editbtn => WebDriver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr//td[3]//i[@class='outline write icon']"));
        //click delete button
        public IWebElement Deltbtn => WebDriver.FindElement(By.XPath(" (//i[contains(@class,'remove icon')])[1]"));
        //click update button to update edited languages
        public IWebElement Updatebtn => WebDriver.FindElement(By.XPath("//input[contains(@value,'Update')]"));

        //Click Skillstab
        public IWebElement ClkSkillsTab => WebDriver.FindElement(By.LinkText("Skills"));
        //click add new btn
        public IWebElement SkillAddnewbtn => WebDriver.FindElement(By.XPath("//div[@class='ui teal button']"));
        //enter Skills
        public IWebElement AddSkill => WebDriver.FindElement(By.XPath("//input[@Placeholder ='Add Skill']"));
        //select level for Skills 
        public IWebElement SelectSkillLevel => WebDriver.FindElement(By.XPath("//input[@name ='level']"));
        // click add button to add enterd Skills
        public IWebElement BtnADDSkill => WebDriver.FindElement(By.CssSelector("input[value='Add']"));
        //click edit button   //
        public IWebElement EditSkillbtn => WebDriver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr//td[3]//i[@class='outline write icon']"));
        //click delete button
        public IWebElement DelSkillbtn => WebDriver.FindElement(By.XPath(" (//i[contains(@class,'remove icon')])[1]"));
        //click update button to update edited Skills
        public IWebElement UpdateSkillbtn => WebDriver.FindElement(By.XPath("//input[contains(@value,'Update')]"));

        //Click Educationtab
        public IWebElement ClkEducationTab => WebDriver.FindElement(By.LinkText("Education"));
        //click add new btn
        public IWebElement AddnewEdubtn => WebDriver.FindElement(By.XPath("//div[@id='account-profile-section']/descendant::section[2]/child::div/descendant::div[2]/child::div[3]/form/child::div[4]/descendant::div[6]/table/thead/tr/th[6]/div"));
        //enter college name
        public IWebElement AddCollege => WebDriver.FindElement(By.XPath("//input[@name ='instituteName']"));
        //enter country
        public IWebElement AddCountry => WebDriver.FindElement(By.XPath("//select[@name='country']"));
        // enter Title
        public IWebElement AddTitle => WebDriver.FindElement(By.XPath("//select[@name='title']"));
        // enter degree
        public IWebElement AddDegree => WebDriver.FindElement(By.XPath("//input[@name='degree']"));
        //enter year of graduation
        public IWebElement AddEduYear => WebDriver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
        // click add button to add enterd Education
        public IWebElement BtnADDEdu => WebDriver.FindElement(By.CssSelector("input[value='Add']"));
        //click edit button
        public IWebElement EditEdubtn => WebDriver.FindElement(By.XPath("(//i[contains(@class,'outline write icon')])[5]"));
        //click delete button
        public IWebElement DelEdubtn => WebDriver.FindElement(By.XPath(" (//i[contains(@class,'remove icon')])[1]"));
        //click update button to update edited Education
        public IWebElement UpdateEdubtn => WebDriver.FindElement(By.XPath("//input[contains(@value,'Update')]"));


        //Click certificationtab
        public IWebElement ClkcertificationTab => WebDriver.FindElement(By.LinkText("Certifications"));
        //click add new btn
        public IWebElement AddnewCertibtn => WebDriver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment active tooltip-target'] div[class='ui teal button ']"));
        //enter Certificate name
        public IWebElement AddCertificate => WebDriver.FindElement(By.CssSelector("input[placeholder='Certificate or Award']"));
        //enter Certificate from 
        public IWebElement AddCertificateFrom => WebDriver.FindElement(By.CssSelector("select[name='certificationFrom']"));
        //enter Certificate Year
        public IWebElement AddCertiYear => WebDriver.FindElement(By.XPath("//input[@name='certificationYear']"));
        // click add button to add enterd Certification details
        public IWebElement BtnADDCerti => WebDriver.FindElement(By.CssSelector("input[value='Add']"));
        //click edit button
        public IWebElement EditCertibtn => WebDriver.FindElement(By.XPath("//div[@data-tab='first']//table//tbody//tr//td[3]//i[@class='outline write icon']"));
        //click delete button
        public IWebElement DeltCertibtn => WebDriver.FindElement(By.XPath(" (//i[contains(@class,'remove icon')])[1]"));
        //click update button to update edited Certificate
        public IWebElement UpdateCertibtn => WebDriver.FindElement(By.XPath("//input[contains(@value,'Update')]"));



        public void ClickLanguage() => ClkLangTab.Click();
        public void ClickAddbtn() => Addnewbtn.Click();
        public void ClkAddLangbtn() => BtnADD.Click();
        public void ClickEdit() => Editbtn.Click();
        public void ClickDelete() => Deltbtn.Click();
        public void ClickUpdate() => Updatebtn.Click();

        public void ClickSkill() => ClkSkillsTab.Click();
        public void ClickAddnewSkillBtn() => SkillAddnewbtn.Click();
        public void ClickAddSkillbtn() => BtnADDSkill.Click();
        public void ClickEditSkill() => EditSkillbtn.Click();
        public void ClickDeleteSkill() => DelSkillbtn.Click();
        public void ClickUpdateSkill() => UpdateSkillbtn.Click();
        public void ClickEducationTab() => ClkEducationTab.Click();
        public void ClickAddnewEdubtn() => AddnewEdubtn.Click();
        public void ClickAddEdubtn() => BtnADDEdu.Click();
        public void ClickEditEdu() => EditEdubtn.Click();
        public void ClickDeleteEdu() => DelEdubtn.Click();
        public void ClickUpdateEdu() => UpdateEdubtn.Click();
        public void ClkcertiTab() => ClkcertificationTab.Click();
        public void ClkAddnewcertibtn() => AddnewCertibtn.Click();
        public void ClkAddCerti() => BtnADDCerti.Click();
        public void ClkEditCerti() => EditCertibtn.Click();
        public void ClkDeleteCerti() => DeltCertibtn.Click();
        public void ClkUpdateCertibtn() => UpdateCertibtn.Click();


        public void AddLang(string Language, string LanguageLevel)
        {
            AddLanguage.SendKeys(Language);
            SelectLevel.SendKeys(LanguageLevel);
        }

        public void UpdateLang(string LanguageLevel)
        {
            SelectLevel.SendKeys(LanguageLevel);
        }
        public void AddSkills(string Skills, string Level)
        {
            AddSkill.SendKeys(Skills);
            SelectSkillLevel.SendKeys(Level);
        }

        public void UpdateSkills(string Level)
        {
            SelectSkillLevel.SendKeys(Level);
        }
        public void AddEducation(string collegename, string country, string Title, String degree, String yearofgraduation)
        {
            AddCollege.SendKeys(collegename);
            AddCountry.SendKeys(country);
            AddTitle.SendKeys(Title);
            AddDegree.SendKeys(degree);
            AddEduYear.SendKeys(yearofgraduation);
        }

        public void UpdateEducation(String yearofgraduation)
        {
            AddEduYear.SendKeys(yearofgraduation);
        }
        public void AddCertification(string Certificate, string CertificateFrom, string Year)
        {
            AddCertificate.SendKeys(Certificate);
            AddCertificateFrom.SendKeys(CertificateFrom);
            AddCertiYear.SendKeys(Year);
        }

        public void UpdateCertification(string Year)
        {
            AddCertiYear.SendKeys(Year);
        }

    }
}


