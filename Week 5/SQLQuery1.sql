/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [loginDate]
      ,[logoutDate]
      ,[userID]
      ,[logID]
  FROM [YMCA].[YMCADBUser].[userOverallTime]
  --Insert into userOverallTime(loginDate,userID) Values('9/29/2022 09:46',5)
  --Update userOverallTime Set logoutDate = '9/29/2022 10:20'
  --Where userID = 5

  Select userName, loginDate, logoutDate From Users Inner Join userOverallTime
  On Users.userID = userOverallTime.userID
