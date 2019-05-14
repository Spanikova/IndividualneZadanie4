using OrganizationalStructure.Data.Enums;
using OrganizationalStructure.Data.Repositories;
using OrganizationalStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Logic
{
    public class OrgStructureLogic
    {
        SectionRepository _sectionRepository = new SectionRepository();
        EmployeeRepository _employeeRepository = new EmployeeRepository();

        public List<Section> GetSectionsByLevel(OrganizationalLevel level)
        {
            return _sectionRepository.GetSectionsByLevel(level);
        }

        public List<Section> GetSections(OrganizationalLevel level, int? superiorSectionId)
        {
            return _sectionRepository.GetSections(level, superiorSectionId);
        }

        public List<Section> GetSectionsByCompany(string companyCode)
        {
            return _sectionRepository.GetSectionsByCompany(companyCode);
        }

        public List<Employee> GetEmployees(string departmentCode)
        {
            return _employeeRepository.GetEmployeesOfDepartment(departmentCode);
        }

        public List<Employee> GetEmployeesOfCompany(string companyCode)
        {
            return _employeeRepository.GetEmployeesOfCompany(companyCode);
        }

        public Dictionary<OrganizationalLevel, string> GetOrganizationalLevels()
        {
            return EnumDescriptor.GetEnumMembers<OrganizationalLevel>();
        }

        public bool InsertSection(Section section)
        {
            return _sectionRepository.InsertSection(section);
        }

        public bool UpdateSection(Section section)
        {
            return _sectionRepository.UpdateSection(section);
        }

        public bool DeleteSection(string sectionCode, OrganizationalLevel orglevel)
        {
            return _sectionRepository.DeleteSection(sectionCode, orglevel);
        }
    }
}
