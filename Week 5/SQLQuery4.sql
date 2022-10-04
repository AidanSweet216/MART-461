/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [userID]
      ,[activityID]
      ,[timeSpent]
      ,[logID]
  FROM [YMCA].[YMCADBUser].[UserActivityTime]
  --Update UserActivityTime Set logID = 4
  --Where userID = 5