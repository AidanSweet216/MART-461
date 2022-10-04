/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [userID]
      ,[activityID]
      ,[timeSpent]
      ,[logID]
  FROM [YMCA].[YMCADBUser].[UserActivityTime]
  --Insert into UserActivityTime(activityID,userID,timeSpent,logID) Values (1,5,20,1)
  