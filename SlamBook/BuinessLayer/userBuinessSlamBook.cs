using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataBaseLayer;

namespace BuinessLayer
{
    public class userBuinessSlamBook : userDataSlamBook
    {
        private Int32 _slambkId;
        private Int32 _totalRowCount;
        private Int32 _userId;
        private string _slambkName;
        private bool _isQuest;
        private string _slambkTitle;
        private string _slambkImage;
        private string _name;

        public string name
        {
            get { return _name; }
        }
        public Int32 totalRowsCount
        {
            get { return _totalRowCount; }
        }
        public Int32 slambkId
        {
            get { return _slambkId; }
        }
        public Int32 userID
        {
            get { return _userId; }
        }
        public string slambkName
        {
            get { return _slambkName; }
        }
        public bool isquestionTb
        {
            get { return _isQuest; }
        }
        public string slambkTitle
        {
            get { return _slambkTitle; }
        }
        public string slambkImage
        {
            get { return _slambkImage; }
        }
        
        public userBuinessSlamBook()
        { }
        public userBuinessSlamBook(Int32 id, string sbName, bool isQuest, string title,string slambkImage)
            : base(id, sbName, isQuest, title,slambkImage)
        { }
        
        public DataTable getQuestions()
        {
            DataTable dt = readQuestion();
            return dt;
        }
        public void getSlamBase(int userId)
        {
            DataTable dt = readSlamBase(userId);
            if (dt.Rows.Count > 0)
            {
                _slambkId = Convert.ToInt32(dt.Rows[0][0]);
                _userId = Convert.ToInt32(dt.Rows[0][1]);
                _slambkName = Convert.ToString(dt.Rows[0][2]);
                _isQuest = Convert.ToBoolean(dt.Rows[0][3]);
                _slambkTitle = Convert.ToString(dt.Rows[0][4]);
                _slambkImage = Convert.ToString(dt.Rows[0][5]);
            }
        }
        public void insertSlamBK()
        {
            insertSlamBKData();
        }
        public void insertSlamUserQuest(Int32 sbId, Int32 Idarray)
        {
            insertSlamBKUsersQuestions(sbId, Idarray);
            
        }
        public void insertSlamBKUsersNewQuest(string question, Int32 userID, Int32 slamBKId)
        {
            insertSlamBKUsersNewQuestions(question, userID, slamBKId);
        }
        public DataTable readSlamBKUserQuestions(Int32 sbId)
        {
            DataTable dt = new DataTable();
            DataColumn dc;
            DataRow dr;

            dc = new DataColumn();
            dc.DataType = Type.GetType("System.Int32");
            dc.ColumnName = "Id";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = Type.GetType("System.String");
            dc.ColumnName = "Question";
            dt.Columns.Add(dc);

            dc = new DataColumn();
            dc.DataType = Type.GetType("System.Int32");
            dc.ColumnName = "select";
            dt.Columns.Add(dc);

            DataSet ds = readSlamBKUserQuestion(sbId);
            DataTable tb0 = ds.Tables[0];
            DataTable tb1 = ds.Tables[1];

            for (int i = 0; i < tb0.Rows.Count; i++)
            {
                dr = dt.NewRow();
                dr["Id"] = Convert.ToInt32(tb0.Rows[i][0]);
                dr["Question"] = Convert.ToString(tb0.Rows[i][1]);
                dr["select"] = 0;
                dt.Rows.Add(dr);
            }
            
            for (int i = 0; i < tb1.Rows.Count; i++)
            {
                dr = dt.NewRow();
                dr["Id"] = Convert.ToInt32(tb1.Rows[i][0]);
                dr["Question"] = Convert.ToString(tb1.Rows[i][1]);
                dr["select"] = 0;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public DataTable readSlamBKUserQuestEdit(Int32 sbId)
        {
            Int32 totalrecords, maxIndex, j, m, n;
            DataTable myTable = new DataTable();
            DataColumn myCloum;
            DataRow dr;
            
            myCloum = new DataColumn();
            myCloum.DataType= Type.GetType("System.Int32");
            myCloum.ColumnName="Id";
            myTable.Columns.Add(myCloum);
            
            myCloum = new DataColumn();
            myCloum.DataType = Type.GetType("System.String");
            myCloum.ColumnName = "Question";
            myTable.Columns.Add(myCloum);
            
            myCloum = new DataColumn();
            myCloum.DataType = Type.GetType("System.Int32");
            myCloum.ColumnName = "select";
            myTable.Columns.Add(myCloum);            
            
            DataSet ds = readSlamBKUserQuestionEdit(sbId);
            DataTable tb0 = ds.Tables[0];
            DataTable tb1 = ds.Tables[1];
            DataTable tb2 = ds.Tables[2];
            totalrecords = tb0.Rows.Count + tb1.Rows.Count;
            if (tb0.Rows.Count >= tb1.Rows.Count)
            {
                maxIndex = tb0.Rows.Count - 1;
            }
            else
            {
                maxIndex = tb1.Rows.Count - 1;
            }
            m = n = j = 0;
            for (int i = 0; i < totalrecords-1; i++)
            {
                if ((m < tb0.Rows.Count) && (n < tb1.Rows.Count))
                {
                    if ((Convert.ToInt32(tb0.Rows[m][0])) > (Convert.ToInt32(tb1.Rows[n][0])))
                    {
                        dr = myTable.NewRow();
                        dr["Id"] = Convert.ToInt32(tb1.Rows[n][0]);
                        dr["Question"] = Convert.ToString(tb1.Rows[n][1]);
                        dr["select"] = 0;
                        myTable.Rows.Add(dr);
                        n++;                       
                    }
                    else
                    {
                        dr = myTable.NewRow();
                        dr["Id"] = Convert.ToInt32(tb0.Rows[m][0]);
                        dr["Question"] = Convert.ToString(tb0.Rows[m][1]);
                        dr["select"] = 1;
                        myTable.Rows.Add(dr);
                        m++;
                    }
                }
                else if (m<tb0.Rows.Count)
                {
                    for (int s = m; s < tb0.Rows.Count ; s++)
                    {
                        dr = myTable.NewRow();
                        dr["Id"] = Convert.ToInt32(tb0.Rows[s][0]);
                        dr["Question"] = Convert.ToString(tb0.Rows[s][1]);
                        dr["select"] = 1;
                        myTable.Rows.Add(dr);
                    }
                    i = totalrecords;
                }
                else
                {
                    for (int s = n; s < tb1.Rows.Count ; s++)
                    {
                        dr = myTable.NewRow();
                        dr["Id"] = Convert.ToInt32(tb1.Rows[s][0]);
                        dr["Question"] = Convert.ToString(tb1.Rows[s][1]);
                        dr["select"] = 0;
                        myTable.Rows.Add(dr);
                    }
                    i = totalrecords;
                }
            }
            for (int i = 0; i < tb2.Rows.Count; i++)
            {
                dr = myTable.NewRow();
                dr["Id"] = Convert.ToInt32(tb2.Rows[i][0]);
                dr["Question"] = Convert.ToString(tb2.Rows[i][1]);
                dr["select"] = 1;
                myTable.Rows.Add(dr);
            }
            return myTable;
        }
        public void deleteSlamBKUserQuest(Int32 sbid)
        {
            deleteSlamBKUserQuestion(sbid);
        }
        public void deleteSlamBKUserNewQuest(Int32 qid)
        {
            deleteSlamBKUserNewQuestions(qid);
        }
        public DataTable viewSBReqData(Int32 uid)
        {
            DataTable dt = viewSBReq(uid);
            return dt;
        }
        public void acceptSlamBKReqDate(Int32 uid, Int32 sbId)
        {
            acceptSlamBKReq(uid, sbId);
        }
        public void denySlamBKReqData(Int32 uid, Int32 sbId)
        {
            denySlamBKReq(uid, sbId);
        }
        public void updateSBStatusData(Int32 sbid)
        {
            updateSBStatus(sbid);
        }
        public bool checkSlamBKGenData(Int32 uid)
        {
            return checkSlamBKGen(uid);
        }
        public DataTable addSlamBKEnteryData(int uid)
        {
            return addSlamBKEntery(uid);
        }
        public DataTable readusersAnsQuestionData(Int32 sbId, Int32 pno)
        {
            DataTable dt;
            dt = readusersAnsQuestion(sbId, pno);
            _totalRowCount = totalRows;
            return dt;
        }
        public void readslamBKDetailData(Int32 sbid)
        {
            DataTable dt = readslamBKDetail(sbid);
            if (dt.Rows.Count > 0)
            {
                _name = Convert.ToString(dt.Rows[0][0]);
                _slambkName = Convert.ToString(dt.Rows[0][1]);
                _slambkTitle = Convert.ToString(dt.Rows[0][2]);
                _slambkImage = Convert.ToString(dt.Rows[0][3]);
            }
        }
        public void insertUserAnswerData(Int32 sbId, Int32 qid, Int32 uid, string ans)
        {
            insertUserAnswer(sbId, qid, uid, ans);
        }
        public DataTable readSlamBKUserQuestionAnsData(Int32 sbid, Int32 uid, Int32 pno)
        {
            DataTable dt;
            dt = readSlamBKUserQuestionAns(sbid, uid, pno);
            _totalRowCount = totalRows;
            return dt;            
        }
        public void updateSlamBookVisitorData(Int32 sbid, Int32 uid)
        {
            updateSlamBookVisitor(sbid, uid);
        }
        public DataTable listRecentUpdatesByFriendData(Int32 sbid)
        {
            return listRecentUpdatesByFriend(sbid);
        }
    }
}
