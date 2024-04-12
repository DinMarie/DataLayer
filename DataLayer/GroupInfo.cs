using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;

namespace DataLayer
{
    public class GroupInfo
    {
        public List<Group> groupList = new List<Group>();

        public GroupInfo()
        {
            Group groupOne = new Group();
            groupOne.Name = "BTS";
            groupOne.Members = "JIN, SUGA, JHOPE, RM, JIMIN, TAEHYUNG, JUNGKOOK ";
            groupOne.DebutDate = "June 13. 2013";
            groupOne.Company = "Bighit Music";
            groupList.Add(groupOne);


            Group groupTwo = new Group();
            groupTwo.Name = "TXT";
            groupTwo.Members = "YEONJUN, SOOBIN, BEOMGYU, TAEHYUN, HUENINGKAI";
            groupTwo.DebutDate = "March 4. 2019";
            groupTwo.Company = "Bighit Music";
            groupList.Add(groupTwo);

            Group groupThree = new Group();
            groupThree.Name = "Seventeen";
            groupThree.Members = "Scoups, JeongHan, Joshua, Woozi, Wonwoo, Hoshi, Jun, DK, Mingyu, The8,Seungkwan, Vernon, Dino";
            groupThree.DebutDate = "May 26. 2015";
            groupThree.Company = "Pledis Entertainment";
            groupList.Add(groupThree);


            Group groupFour = new Group();
            groupFour.Name = "Twice";
            groupFour.Members = "Nayeon, Jeongyeon, Momo, Sana, Mina, Dahyun, Chaeyoung, Tzuyu";
            groupFour.DebutDate = "October 20. 2015";
            groupFour.Company = "JYP Entertainment";
            groupList.Add(groupFour);

            roup groupFive = new Group();
            groupFive.Name = "Blackpink";
            groupFive.Members = "Jennie, Jisoo, Lisa, Rose";
            groupFive.DebutDate = "August 8. 2016";
            groupFive.Company = "YG Entertainment";
            groupList.Add(groupFive);



        }
        public Group GetGroup(string name)
        {
            Group foundGroup = new Group();

            foreach (var group in groupList)
            {
                if (name == group.Name)
                {
                    foundGroup = group;
                }
            }
            return foundGroup;
        }
    }
}
