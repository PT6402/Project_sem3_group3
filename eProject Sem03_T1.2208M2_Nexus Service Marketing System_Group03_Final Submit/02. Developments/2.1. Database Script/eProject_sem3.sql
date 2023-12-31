USE [eProject_sem3]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Banner]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banner](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Path] [nvarchar](max) NULL,
 CONSTRAINT [PK_Banner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedbacks]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedbacks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [int] NOT NULL,
	[Duration_Id] [int] NOT NULL,
	[Address_Store_Id] [int] NOT NULL,
	[Content] [nvarchar](100) NOT NULL,
	[Reply] [nvarchar](100) NULL,
 CONSTRAINT [PK_Feedbacks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_handler]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_handler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address_store_Id] [int] NOT NULL,
	[Order_Id] [nvarchar](450) NOT NULL,
	[Employee_Id] [int] NOT NULL,
	[StatusHandle] [bit] NOT NULL,
 CONSTRAINT [PK_Order_handler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbAddress]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAddress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address_full] [nvarchar](max) NOT NULL,
	[Phone_code] [nvarchar](max) NOT NULL,
	[Province_code] [nvarchar](max) NOT NULL,
	[District_code] [nvarchar](max) NOT NULL,
	[Ward_code] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tbAddress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbAddress_store]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAddress_store](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address_Id] [int] NOT NULL,
 CONSTRAINT [PK_tbAddress_store] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCall_charges]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCall_charges](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [real] NOT NULL,
	[Unit] [nvarchar](max) NOT NULL,
	[Duration_Id] [int] NOT NULL,
 CONSTRAINT [PK_tbCall_charges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbConnect_type]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbConnect_type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[First_Letter] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Security_Deposit] [real] NOT NULL,
 CONSTRAINT [PK_tbConnect_type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbContract_Service]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbContract_Service](
	[Id] [nvarchar](450) NOT NULL,
	[Order_Id] [nvarchar](450) NOT NULL,
	[TP_Contract_Id] [nvarchar](450) NOT NULL,
	[ContractCode] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbContract_Service] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCoupon]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCoupon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[To] [int] NOT NULL,
	[From] [int] NOT NULL,
	[Percent_discount] [real] NOT NULL,
 CONSTRAINT [PK_tbCoupon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbDuration]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDuration](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Package_Id] [int] NOT NULL,
	[Time] [nvarchar](max) NULL,
	[Price] [real] NOT NULL,
	[Validate] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbDuration] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbDuration_callCharges]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDuration_callCharges](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Duration_Id] [int] NOT NULL,
	[Call_charges_Id] [int] NULL,
 CONSTRAINT [PK_tbDuration_callCharges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEmployee]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEmployee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [int] NOT NULL,
	[Employee_type_Id] [int] NOT NULL,
	[Address_store_Id] [int] NOT NULL,
 CONSTRAINT [PK_tbEmployee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEmployee_type]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEmployee_type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tbEmployee_type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbImportReceipt]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbImportReceipt](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Product_Id] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Time] [datetime2](7) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[Storage_id] [int] NOT NULL,
 CONSTRAINT [PK_tbImportReceipt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbOrders]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbOrders](
	[Id] [nvarchar](450) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[Tax] [nvarchar](max) NOT NULL,
	[Total_Price] [real] NOT NULL,
	[Numb_Connect] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[Coupon_Id] [int] NULL,
	[ContractService_Id] [nvarchar](max) NULL,
	[Duration_callCharges_Id] [int] NULL,
	[Duration_Id] [int] NOT NULL,
	[User_Id] [int] NOT NULL,
	[Addresses_Id] [int] NOT NULL,
 CONSTRAINT [PK_tbOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPackage]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPackage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Connect_type_Id] [int] NOT NULL,
 CONSTRAINT [PK_tbPackage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPayment]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPayment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Order_Id] [nvarchar](450) NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[Method_Payment] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_tbPayment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProduct]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Numb_Connect] [int] NOT NULL,
	[Connect_type_Id] [int] NOT NULL,
	[Supplier_Id] [int] NOT NULL,
 CONSTRAINT [PK_tbProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbStorage]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbStorage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address_store_id] [int] NOT NULL,
 CONSTRAINT [PK_tbStorage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbSupplier]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSupplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[brandName] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbSupplier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTP_contract]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTP_contract](
	[Id] [nvarchar](450) NOT NULL,
	[User_Id] [int] NOT NULL,
 CONSTRAINT [PK_tbTP_contract] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUser]    Script Date: 1/8/2024 10:35:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Role] [nvarchar](max) NOT NULL,
	[PasswordHash] [varbinary](max) NOT NULL,
	[PasswordSalt] [varbinary](max) NOT NULL,
	[RefreshToken] [nvarchar](max) NULL,
	[TokenCreated] [datetime2](7) NULL,
	[TokenExpires] [datetime2](7) NULL,
	[PasswordReset] [nvarchar](max) NULL,
	[ResetExpires] [datetime2](7) NULL,
	[MethodReset] [int] NULL,
	[TP_contract_Id] [nvarchar](450) NULL,
	[Employees_Id] [int] NULL,
	[Status] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240108043319_v0', N'7.0.14')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240108112633_v1', N'7.0.14')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240108152936_v3', N'7.0.14')
GO
SET IDENTITY_INSERT [dbo].[tbAddress] ON 

INSERT [dbo].[tbAddress] ([Id], [Address_full], [Phone_code], [Province_code], [District_code], [Ward_code]) VALUES (1, N'tuyen quang, ha hang, thuong giap', N'207', N'8', N'72', N'2230')
INSERT [dbo].[tbAddress] ([Id], [Address_full], [Phone_code], [Province_code], [District_code], [Ward_code]) VALUES (2, N'quang ninh , huyen binh lieu, dong van', N'203', N'22', N'198', N'6847')
INSERT [dbo].[tbAddress] ([Id], [Address_full], [Phone_code], [Province_code], [District_code], [Ward_code]) VALUES (3, N'soc trang, long phu, phu huu', N'299', N'94', N'946', N'31657')
INSERT [dbo].[tbAddress] ([Id], [Address_full], [Phone_code], [Province_code], [District_code], [Ward_code]) VALUES (4, N'cao bang , bao lac , thuong ha', N'206', N'4', N'43', N'1327')
SET IDENTITY_INSERT [dbo].[tbAddress] OFF
GO
SET IDENTITY_INSERT [dbo].[tbAddress_store] ON 

INSERT [dbo].[tbAddress_store] ([Id], [Address_Id]) VALUES (1, 1)
INSERT [dbo].[tbAddress_store] ([Id], [Address_Id]) VALUES (2, 2)
INSERT [dbo].[tbAddress_store] ([Id], [Address_Id]) VALUES (3, 3)
INSERT [dbo].[tbAddress_store] ([Id], [Address_Id]) VALUES (4, 4)
SET IDENTITY_INSERT [dbo].[tbAddress_store] OFF
GO
SET IDENTITY_INSERT [dbo].[tbCall_charges] ON 

INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (1, N'Local ULT', 55, N'cent/min', 14)
INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (2, N'Local M', 75, N'cent/min', 15)
INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (3, N'Local', 70, N'cent/min', 16)
INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (4, N'STD', 2.25, N'$/min', 16)
INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (5, N'Messaging for mobiles', 1, N'$/min', 16)
INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (6, N'Local', 60, N'cent/min', 17)
INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (7, N'STD', 2, N'$/min', 17)
INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (8, N'Messaging for mobiles', 1.15, N'$/min', 17)
INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (9, N'Local', 60, N'cent/min', 18)
INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (10, N'STD', 1.75, N'$/min', 18)
INSERT [dbo].[tbCall_charges] ([Id], [Name], [Price], [Unit], [Duration_Id]) VALUES (11, N'Messaging for mobiles', 1.12, N'$/min', 18)
SET IDENTITY_INSERT [dbo].[tbCall_charges] OFF
GO
SET IDENTITY_INSERT [dbo].[tbConnect_type] ON 

INSERT [dbo].[tbConnect_type] ([Id], [Name], [First_Letter], [Description], [Security_Deposit]) VALUES (1, N'Dial-up', N'D', N'dial-up', 325)
INSERT [dbo].[tbConnect_type] ([Id], [Name], [First_Letter], [Description], [Security_Deposit]) VALUES (2, N'Broad Band', N'B', N'Broad Band', 500)
INSERT [dbo].[tbConnect_type] ([Id], [Name], [First_Letter], [Description], [Security_Deposit]) VALUES (3, N'LandLine', N'L', N'LandLine', 250)
SET IDENTITY_INSERT [dbo].[tbConnect_type] OFF
GO
SET IDENTITY_INSERT [dbo].[tbCoupon] ON 

INSERT [dbo].[tbCoupon] ([Id], [Name], [To], [From], [Percent_discount]) VALUES (1, N'code coupon', 10, 15, 25)
INSERT [dbo].[tbCoupon] ([Id], [Name], [To], [From], [Percent_discount]) VALUES (2, N'code coupon 1', 15, 25, 50)
INSERT [dbo].[tbCoupon] ([Id], [Name], [To], [From], [Percent_discount]) VALUES (3, N'code coupon 2', 25, 50, 75)
INSERT [dbo].[tbCoupon] ([Id], [Name], [To], [From], [Percent_discount]) VALUES (4, N'code coupon 3', 50, 1000, 100)
SET IDENTITY_INSERT [dbo].[tbCoupon] OFF
GO
SET IDENTITY_INSERT [dbo].[tbDuration] ON 

INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (1, 1, N'10Hrs', 50, N'1', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (2, 1, N'30Hrs', 130, N'3', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (3, 1, N'60Hrs', 260, N'6', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (4, 2, N'Monthly', 75, N'1', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (5, 2, N'Quarterly', 150, N'3', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (6, 3, N'Monthly', 100, N'1', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (7, 3, N'Quarterly', 180, N'3', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (8, 4, N'30Hrs', 175, N'1', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (9, 4, N'60Hrs', 315, N'3', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (10, 5, N'Monthly', 225, N'1', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (11, 5, N'Quarterly', 400, N'3', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (12, 6, N'Monthly', 350, N'1', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (13, 6, N'Quarterly', 445, N'3', NULL)
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (14, 7, N'Unlimited', 75, N'12', N'Local ULT : 55 cent/min')
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (15, 7, N'Monthly', 35, N'1', N'Local M: 75cent/min')
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (16, 8, N'Monthly', 125, N'1', N'Local: 70cent/min; STD:2.25$/min ; Messaging for mobiles:1$/min')
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (17, 8, N'Half-Yearly', 420, N'6', N'Local: 60cent/min; STD:2$/min ; Messaging for mobiles:1.15$/min')
INSERT [dbo].[tbDuration] ([Id], [Package_Id], [Time], [Price], [Validate], [Description]) VALUES (18, 8, N'Yearly', 799, N'12', N'Local: 60cent/min; STD:1.75$/min ; Messaging for mobiles:1.12$/min')
SET IDENTITY_INSERT [dbo].[tbDuration] OFF
GO
SET IDENTITY_INSERT [dbo].[tbDuration_callCharges] ON 

INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (1, 1, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (2, 2, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (3, 3, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (4, 4, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (5, 5, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (6, 6, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (7, 7, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (8, 8, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (9, 9, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (10, 10, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (11, 11, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (12, 12, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (13, 13, NULL)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (14, 14, 1)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (15, 15, 2)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (16, 16, 3)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (17, 16, 4)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (18, 16, 5)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (19, 17, 6)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (20, 17, 7)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (21, 17, 8)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (22, 18, 9)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (23, 18, 10)
INSERT [dbo].[tbDuration_callCharges] ([Id], [Duration_Id], [Call_charges_Id]) VALUES (24, 18, 11)
SET IDENTITY_INSERT [dbo].[tbDuration_callCharges] OFF
GO
SET IDENTITY_INSERT [dbo].[tbEmployee] ON 

INSERT [dbo].[tbEmployee] ([Id], [User_Id], [Employee_type_Id], [Address_store_Id]) VALUES (1, 3, 1, 1)
INSERT [dbo].[tbEmployee] ([Id], [User_Id], [Employee_type_Id], [Address_store_Id]) VALUES (2, 4, 2, 1)
INSERT [dbo].[tbEmployee] ([Id], [User_Id], [Employee_type_Id], [Address_store_Id]) VALUES (3, 5, 1, 2)
INSERT [dbo].[tbEmployee] ([Id], [User_Id], [Employee_type_Id], [Address_store_Id]) VALUES (4, 8, 2, 2)
INSERT [dbo].[tbEmployee] ([Id], [User_Id], [Employee_type_Id], [Address_store_Id]) VALUES (5, 6, 1, 3)
INSERT [dbo].[tbEmployee] ([Id], [User_Id], [Employee_type_Id], [Address_store_Id]) VALUES (6, 9, 2, 3)
INSERT [dbo].[tbEmployee] ([Id], [User_Id], [Employee_type_Id], [Address_store_Id]) VALUES (7, 7, 1, 4)
INSERT [dbo].[tbEmployee] ([Id], [User_Id], [Employee_type_Id], [Address_store_Id]) VALUES (8, 10, 2, 4)
SET IDENTITY_INSERT [dbo].[tbEmployee] OFF
GO
SET IDENTITY_INSERT [dbo].[tbEmployee_type] ON 

INSERT [dbo].[tbEmployee_type] ([Id], [Name]) VALUES (1, N'Sale')
INSERT [dbo].[tbEmployee_type] ([Id], [Name]) VALUES (2, N'Technician')
SET IDENTITY_INSERT [dbo].[tbEmployee_type] OFF
GO
SET IDENTITY_INSERT [dbo].[tbImportReceipt] ON 

INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (1, 1, 10, CAST(N'2024-01-08T22:29:36.0583032' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (2, 2, 15, CAST(N'2024-01-08T22:29:36.0583041' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (3, 3, 20, CAST(N'2024-01-08T22:29:36.0583042' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (4, 4, 30, CAST(N'2024-01-08T22:29:36.0583043' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (5, 5, 10, CAST(N'2024-01-08T22:29:36.0583044' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (6, 6, 15, CAST(N'2024-01-08T22:29:36.0583045' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (7, 7, 20, CAST(N'2024-01-08T22:29:36.0583047' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (8, 8, 30, CAST(N'2024-01-08T22:29:36.0583048' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (9, 9, 10, CAST(N'2024-01-08T22:29:36.0583049' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (10, 10, 15, CAST(N'2024-01-08T22:29:36.0583050' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (11, 11, 20, CAST(N'2024-01-08T22:29:36.0583051' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (12, 12, 30, CAST(N'2024-01-08T22:29:36.0583052' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (13, 13, 10, CAST(N'2024-01-08T22:29:36.0583053' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (14, 14, 15, CAST(N'2024-01-08T22:29:36.0583054' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (15, 15, 20, CAST(N'2024-01-08T22:29:36.0583055' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (16, 16, 30, CAST(N'2024-01-08T22:29:36.0583056' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (17, 17, 15, CAST(N'2024-01-08T22:29:36.0583057' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (18, 18, 20, CAST(N'2024-01-08T22:29:36.0583058' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (19, 1, 10, CAST(N'2024-01-08T22:29:36.0583059' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (20, 2, 15, CAST(N'2024-01-08T22:29:36.0583060' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (21, 3, 20, CAST(N'2024-01-08T22:29:36.0583061' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (22, 4, 30, CAST(N'2024-01-08T22:29:36.0583062' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (23, 5, 10, CAST(N'2024-01-08T22:29:36.0583064' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (24, 6, 15, CAST(N'2024-01-08T22:29:36.0583065' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (25, 7, 20, CAST(N'2024-01-08T22:29:36.0583066' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (26, 8, 30, CAST(N'2024-01-08T22:29:36.0583067' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (27, 9, 10, CAST(N'2024-01-08T22:29:36.0583068' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (28, 10, 15, CAST(N'2024-01-08T22:29:36.0583069' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (29, 11, 20, CAST(N'2024-01-08T22:29:36.0583070' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (30, 12, 30, CAST(N'2024-01-08T22:29:36.0583071' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (31, 13, 10, CAST(N'2024-01-08T22:29:36.0583072' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (32, 14, 15, CAST(N'2024-01-08T22:29:36.0583079' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (33, 15, 20, CAST(N'2024-01-08T22:29:36.0583080' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (34, 16, 30, CAST(N'2024-01-08T22:29:36.0583081' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (35, 17, 15, CAST(N'2024-01-08T22:29:36.0583082' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (36, 18, 20, CAST(N'2024-01-08T22:29:36.0583083' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (37, 1, 10, CAST(N'2024-01-08T22:29:36.0583084' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (38, 2, 15, CAST(N'2024-01-08T22:29:36.0583085' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (39, 3, 20, CAST(N'2024-01-08T22:29:36.0583086' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (40, 4, 30, CAST(N'2024-01-08T22:29:36.0583086' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (41, 5, 10, CAST(N'2024-01-08T22:29:36.0583088' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (42, 6, 15, CAST(N'2024-01-08T22:29:36.0583089' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (43, 7, 20, CAST(N'2024-01-08T22:29:36.0583090' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (44, 8, 30, CAST(N'2024-01-08T22:29:36.0583091' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (45, 9, 10, CAST(N'2024-01-08T22:29:36.0583092' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (46, 10, 15, CAST(N'2024-01-08T22:29:36.0583093' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (47, 11, 20, CAST(N'2024-01-08T22:29:36.0583094' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (48, 12, 30, CAST(N'2024-01-08T22:29:36.0583095' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (49, 13, 10, CAST(N'2024-01-08T22:29:36.0583096' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (50, 14, 15, CAST(N'2024-01-08T22:29:36.0583097' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (51, 15, 20, CAST(N'2024-01-08T22:29:36.0583098' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (52, 16, 30, CAST(N'2024-01-08T22:29:36.0583099' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (53, 17, 15, CAST(N'2024-01-08T22:29:36.0583100' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (54, 18, 20, CAST(N'2024-01-08T22:29:36.0583101' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (55, 1, 10, CAST(N'2024-01-08T22:29:36.0583102' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (56, 2, 15, CAST(N'2024-01-08T22:29:36.0583102' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (57, 3, 20, CAST(N'2024-01-08T22:29:36.0583104' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (58, 4, 30, CAST(N'2024-01-08T22:29:36.0583105' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (59, 5, 10, CAST(N'2024-01-08T22:29:36.0583106' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (60, 6, 15, CAST(N'2024-01-08T22:29:36.0583106' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (61, 7, 20, CAST(N'2024-01-08T22:29:36.0583107' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (62, 8, 30, CAST(N'2024-01-08T22:29:36.0583109' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (63, 9, 10, CAST(N'2024-01-08T22:29:36.0583109' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (64, 10, 15, CAST(N'2024-01-08T22:29:36.0583110' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (65, 11, 20, CAST(N'2024-01-08T22:29:36.0583111' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (66, 12, 30, CAST(N'2024-01-08T22:29:36.0583112' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (67, 13, 10, CAST(N'2024-01-08T22:29:36.0583113' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (68, 14, 15, CAST(N'2024-01-08T22:29:36.0583114' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (69, 15, 20, CAST(N'2024-01-08T22:29:36.0583115' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (70, 16, 30, CAST(N'2024-01-08T22:29:36.0583116' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (71, 17, 15, CAST(N'2024-01-08T22:29:36.0583117' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (72, 18, 20, CAST(N'2024-01-08T22:29:36.0583118' AS DateTime2), N'Done', 4)
SET IDENTITY_INSERT [dbo].[tbImportReceipt] OFF
GO
SET IDENTITY_INSERT [dbo].[tbPackage] ON 

INSERT [dbo].[tbPackage] ([Id], [Name], [Connect_type_Id]) VALUES (1, N'Hourly Basic', 1)
INSERT [dbo].[tbPackage] ([Id], [Name], [Connect_type_Id]) VALUES (2, N'Unlimited 28Kbps', 1)
INSERT [dbo].[tbPackage] ([Id], [Name], [Connect_type_Id]) VALUES (3, N'Unlimited 56Kbps', 1)
INSERT [dbo].[tbPackage] ([Id], [Name], [Connect_type_Id]) VALUES (4, N'Hourly Basic', 2)
INSERT [dbo].[tbPackage] ([Id], [Name], [Connect_type_Id]) VALUES (5, N'Unlimited 64Kbps', 2)
INSERT [dbo].[tbPackage] ([Id], [Name], [Connect_type_Id]) VALUES (6, N'Unlimited 128Kbps', 2)
INSERT [dbo].[tbPackage] ([Id], [Name], [Connect_type_Id]) VALUES (7, N'Local Plan= Rental + Callcharges', 3)
INSERT [dbo].[tbPackage] ([Id], [Name], [Connect_type_Id]) VALUES (8, N'STD Plan', 3)
SET IDENTITY_INSERT [dbo].[tbPackage] OFF
GO
SET IDENTITY_INSERT [dbo].[tbProduct] ON 

INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (1, N'UniFi AC Lite', 10, 1, 1)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (2, N'UniFi AC Pro', 15, 1, 1)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (3, N'UniFi AC Nano', 25, 1, 1)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (4, N'UniFi AC NanoPro', 51, 1, 1)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (5, N'GrandStream AC Lite', 10, 1, 2)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (6, N'GrandStream AC Pro', 15, 1, 2)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (7, N'GrandStream AC Nano', 25, 1, 2)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (8, N'GrandStream AC NanoPro', 51, 1, 2)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (9, N'UniFi AC Lite Max', 10, 2, 1)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (10, N'UniFi AC Pro Max', 15, 2, 1)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (11, N'UniFi AC Nano Max', 25, 2, 1)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (12, N'UniFi AC NanoPro Max', 51, 2, 1)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (13, N'GrandStream AC Lite Max', 10, 2, 2)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (14, N'GrandStream AC Pro Max', 15, 2, 2)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (15, N'GrandStream AC Nano Max', 25, 2, 2)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (16, N'GrandStream AC NanoPro Max', 51, 2, 2)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (17, N'KXTS500', 10, 3, 3)
INSERT [dbo].[tbProduct] ([Id], [Name], [Numb_Connect], [Connect_type_Id], [Supplier_Id]) VALUES (18, N'IP Fanvil X7A', 15, 3, 3)
SET IDENTITY_INSERT [dbo].[tbProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[tbStorage] ON 

INSERT [dbo].[tbStorage] ([Id], [Address_store_id]) VALUES (1, 1)
INSERT [dbo].[tbStorage] ([Id], [Address_store_id]) VALUES (2, 2)
INSERT [dbo].[tbStorage] ([Id], [Address_store_id]) VALUES (3, 3)
INSERT [dbo].[tbStorage] ([Id], [Address_store_id]) VALUES (4, 4)
SET IDENTITY_INSERT [dbo].[tbStorage] OFF
GO
SET IDENTITY_INSERT [dbo].[tbSupplier] ON 

INSERT [dbo].[tbSupplier] ([Id], [brandName], [Phone], [Address]) VALUES (1, N'UniFi', N'0462146762', N'ha noi')
INSERT [dbo].[tbSupplier] ([Id], [brandName], [Phone], [Address]) VALUES (2, N'Grandstream', N'0646272131', N'ha noi')
INSERT [dbo].[tbSupplier] ([Id], [brandName], [Phone], [Address]) VALUES (3, N'Panasonic', N'0646272131', N'ha noi')
SET IDENTITY_INSERT [dbo].[tbSupplier] OFF
GO
SET IDENTITY_INSERT [dbo].[tbUser] ON 

INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id], [Status]) VALUES (1, N'Nguyen Van Thien', N'0932859395', NULL, N'user', 0xCF96E0524E9D3F0F44B327194925F8C3F936B67B64D709D2083EB86069282AFD23F86FD646612200C3E1B44CFA203825FF5A35F1E53BFEDAE6BCC6A6FAE49CF3, 0x808BBBCB90E5F4E4CD3D0DAA44BF90A5770D787A2C3588DCF7723292A9BD851B3D94939AF585ABB0D86313F6928B284C1E1603BDFAFBEF34F7E1B3343CD1CBCC9610312EF833D5763908F24A39E0862AF8217C0ECA4BD9C38A971584970B738A659F37782A7A67341F470007282F523D5170AEFE84848FDA62B6A1ECB039120D, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Active')
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id], [Status]) VALUES (2, N'admin', N'0971866177', NULL, N'admin', 0xCF96E0524E9D3F0F44B327194925F8C3F936B67B64D709D2083EB86069282AFD23F86FD646612200C3E1B44CFA203825FF5A35F1E53BFEDAE6BCC6A6FAE49CF3, 0x808BBBCB90E5F4E4CD3D0DAA44BF90A5770D787A2C3588DCF7723292A9BD851B3D94939AF585ABB0D86313F6928B284C1E1603BDFAFBEF34F7E1B3343CD1CBCC9610312EF833D5763908F24A39E0862AF8217C0ECA4BD9C38A971584970B738A659F37782A7A67341F470007282F523D5170AEFE84848FDA62B6A1ECB039120D, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id], [Status]) VALUES (3, N'Tran Thien Hieu', N'0123456789', NULL, N'sale', 0xCF96E0524E9D3F0F44B327194925F8C3F936B67B64D709D2083EB86069282AFD23F86FD646612200C3E1B44CFA203825FF5A35F1E53BFEDAE6BCC6A6FAE49CF3, 0x808BBBCB90E5F4E4CD3D0DAA44BF90A5770D787A2C3588DCF7723292A9BD851B3D94939AF585ABB0D86313F6928B284C1E1603BDFAFBEF34F7E1B3343CD1CBCC9610312EF833D5763908F24A39E0862AF8217C0ECA4BD9C38A971584970B738A659F37782A7A67341F470007282F523D5170AEFE84848FDA62B6A1ECB039120D, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id], [Status]) VALUES (4, N'Tran Van Phat', N'0987654321', NULL, N'Technical', 0xCF96E0524E9D3F0F44B327194925F8C3F936B67B64D709D2083EB86069282AFD23F86FD646612200C3E1B44CFA203825FF5A35F1E53BFEDAE6BCC6A6FAE49CF3, 0x808BBBCB90E5F4E4CD3D0DAA44BF90A5770D787A2C3588DCF7723292A9BD851B3D94939AF585ABB0D86313F6928B284C1E1603BDFAFBEF34F7E1B3343CD1CBCC9610312EF833D5763908F24A39E0862AF8217C0ECA4BD9C38A971584970B738A659F37782A7A67341F470007282F523D5170AEFE84848FDA62B6A1ECB039120D, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id], [Status]) VALUES (5, N'Nguyen Van A', N'0796526595', NULL, N'sale', 0xCF96E0524E9D3F0F44B327194925F8C3F936B67B64D709D2083EB86069282AFD23F86FD646612200C3E1B44CFA203825FF5A35F1E53BFEDAE6BCC6A6FAE49CF3, 0x808BBBCB90E5F4E4CD3D0DAA44BF90A5770D787A2C3588DCF7723292A9BD851B3D94939AF585ABB0D86313F6928B284C1E1603BDFAFBEF34F7E1B3343CD1CBCC9610312EF833D5763908F24A39E0862AF8217C0ECA4BD9C38A971584970B738A659F37782A7A67341F470007282F523D5170AEFE84848FDA62B6A1ECB039120D, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id], [Status]) VALUES (6, N'Nguyen Van B', N'0955797871', NULL, N'sale', 0xCF96E0524E9D3F0F44B327194925F8C3F936B67B64D709D2083EB86069282AFD23F86FD646612200C3E1B44CFA203825FF5A35F1E53BFEDAE6BCC6A6FAE49CF3, 0x808BBBCB90E5F4E4CD3D0DAA44BF90A5770D787A2C3588DCF7723292A9BD851B3D94939AF585ABB0D86313F6928B284C1E1603BDFAFBEF34F7E1B3343CD1CBCC9610312EF833D5763908F24A39E0862AF8217C0ECA4BD9C38A971584970B738A659F37782A7A67341F470007282F523D5170AEFE84848FDA62B6A1ECB039120D, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id], [Status]) VALUES (7, N'Nguyen Van C', N'0689764123', NULL, N'sale', 0xCF96E0524E9D3F0F44B327194925F8C3F936B67B64D709D2083EB86069282AFD23F86FD646612200C3E1B44CFA203825FF5A35F1E53BFEDAE6BCC6A6FAE49CF3, 0x808BBBCB90E5F4E4CD3D0DAA44BF90A5770D787A2C3588DCF7723292A9BD851B3D94939AF585ABB0D86313F6928B284C1E1603BDFAFBEF34F7E1B3343CD1CBCC9610312EF833D5763908F24A39E0862AF8217C0ECA4BD9C38A971584970B738A659F37782A7A67341F470007282F523D5170AEFE84848FDA62B6A1ECB039120D, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id], [Status]) VALUES (8, N'Nguyen Van D', N'0689434167', NULL, N'Technical', 0xCF96E0524E9D3F0F44B327194925F8C3F936B67B64D709D2083EB86069282AFD23F86FD646612200C3E1B44CFA203825FF5A35F1E53BFEDAE6BCC6A6FAE49CF3, 0x808BBBCB90E5F4E4CD3D0DAA44BF90A5770D787A2C3588DCF7723292A9BD851B3D94939AF585ABB0D86313F6928B284C1E1603BDFAFBEF34F7E1B3343CD1CBCC9610312EF833D5763908F24A39E0862AF8217C0ECA4BD9C38A971584970B738A659F37782A7A67341F470007282F523D5170AEFE84848FDA62B6A1ECB039120D, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id], [Status]) VALUES (9, N'Nguyen Van E', N'0689764139', NULL, N'Technical', 0xCF96E0524E9D3F0F44B327194925F8C3F936B67B64D709D2083EB86069282AFD23F86FD646612200C3E1B44CFA203825FF5A35F1E53BFEDAE6BCC6A6FAE49CF3, 0x808BBBCB90E5F4E4CD3D0DAA44BF90A5770D787A2C3588DCF7723292A9BD851B3D94939AF585ABB0D86313F6928B284C1E1603BDFAFBEF34F7E1B3343CD1CBCC9610312EF833D5763908F24A39E0862AF8217C0ECA4BD9C38A971584970B738A659F37782A7A67341F470007282F523D5170AEFE84848FDA62B6A1ECB039120D, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id], [Status]) VALUES (10, N'Nguyen Van F', N'0329764195', NULL, N'Technical', 0xCF96E0524E9D3F0F44B327194925F8C3F936B67B64D709D2083EB86069282AFD23F86FD646612200C3E1B44CFA203825FF5A35F1E53BFEDAE6BCC6A6FAE49CF3, 0x808BBBCB90E5F4E4CD3D0DAA44BF90A5770D787A2C3588DCF7723292A9BD851B3D94939AF585ABB0D86313F6928B284C1E1603BDFAFBEF34F7E1B3343CD1CBCC9610312EF833D5763908F24A39E0862AF8217C0ECA4BD9C38A971584970B738A659F37782A7A67341F470007282F523D5170AEFE84848FDA62B6A1ECB039120D, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbUser] OFF
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD  CONSTRAINT [FK_FeedBack_Duration] FOREIGN KEY([Duration_Id])
REFERENCES [dbo].[tbDuration] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Feedbacks] CHECK CONSTRAINT [FK_FeedBack_Duration]
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_User] FOREIGN KEY([User_Id])
REFERENCES [dbo].[tbUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Feedbacks] CHECK CONSTRAINT [FK_Feedback_User]
GO
ALTER TABLE [dbo].[Order_handler]  WITH CHECK ADD  CONSTRAINT [FK_Order_handle_Address_store] FOREIGN KEY([Address_store_Id])
REFERENCES [dbo].[tbAddress_store] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order_handler] CHECK CONSTRAINT [FK_Order_handle_Address_store]
GO
ALTER TABLE [dbo].[Order_handler]  WITH CHECK ADD  CONSTRAINT [FK_Order_handle_Employee] FOREIGN KEY([Employee_Id])
REFERENCES [dbo].[tbEmployee] ([Id])
GO
ALTER TABLE [dbo].[Order_handler] CHECK CONSTRAINT [FK_Order_handle_Employee]
GO
ALTER TABLE [dbo].[Order_handler]  WITH CHECK ADD  CONSTRAINT [FK_Order_handle_Order] FOREIGN KEY([Order_Id])
REFERENCES [dbo].[tbOrders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order_handler] CHECK CONSTRAINT [FK_Order_handle_Order]
GO
ALTER TABLE [dbo].[tbAddress_store]  WITH CHECK ADD  CONSTRAINT [FK_Address_store_Addresses] FOREIGN KEY([Address_Id])
REFERENCES [dbo].[tbAddress] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbAddress_store] CHECK CONSTRAINT [FK_Address_store_Addresses]
GO
ALTER TABLE [dbo].[tbCall_charges]  WITH CHECK ADD  CONSTRAINT [FK_Call_charges_Duration] FOREIGN KEY([Duration_Id])
REFERENCES [dbo].[tbDuration] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbCall_charges] CHECK CONSTRAINT [FK_Call_charges_Duration]
GO
ALTER TABLE [dbo].[tbContract_Service]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Services_Order] FOREIGN KEY([Order_Id])
REFERENCES [dbo].[tbOrders] ([Id])
GO
ALTER TABLE [dbo].[tbContract_Service] CHECK CONSTRAINT [FK_Contract_Services_Order]
GO
ALTER TABLE [dbo].[tbContract_Service]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Services_TpContractor] FOREIGN KEY([TP_Contract_Id])
REFERENCES [dbo].[tbTP_contract] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbContract_Service] CHECK CONSTRAINT [FK_Contract_Services_TpContractor]
GO
ALTER TABLE [dbo].[tbDuration]  WITH CHECK ADD  CONSTRAINT [FK_Duration_Package] FOREIGN KEY([Package_Id])
REFERENCES [dbo].[tbPackage] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbDuration] CHECK CONSTRAINT [FK_Duration_Package]
GO
ALTER TABLE [dbo].[tbDuration_callCharges]  WITH CHECK ADD  CONSTRAINT [FK_Duration_callCharges_Call_charges] FOREIGN KEY([Call_charges_Id])
REFERENCES [dbo].[tbCall_charges] ([Id])
GO
ALTER TABLE [dbo].[tbDuration_callCharges] CHECK CONSTRAINT [FK_Duration_callCharges_Call_charges]
GO
ALTER TABLE [dbo].[tbDuration_callCharges]  WITH CHECK ADD  CONSTRAINT [FK_Duration_callCharges_Duration] FOREIGN KEY([Duration_Id])
REFERENCES [dbo].[tbDuration] ([Id])
GO
ALTER TABLE [dbo].[tbDuration_callCharges] CHECK CONSTRAINT [FK_Duration_callCharges_Duration]
GO
ALTER TABLE [dbo].[tbEmployee]  WITH CHECK ADD  CONSTRAINT [FK_Emp_Address_store] FOREIGN KEY([Address_store_Id])
REFERENCES [dbo].[tbAddress_store] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbEmployee] CHECK CONSTRAINT [FK_Emp_Address_store]
GO
ALTER TABLE [dbo].[tbEmployee]  WITH CHECK ADD  CONSTRAINT [FK_Emp_Emp_type] FOREIGN KEY([Employee_type_Id])
REFERENCES [dbo].[tbEmployee_type] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbEmployee] CHECK CONSTRAINT [FK_Emp_Emp_type]
GO
ALTER TABLE [dbo].[tbImportReceipt]  WITH CHECK ADD  CONSTRAINT [FK_ImportReceipt_Storage] FOREIGN KEY([Storage_id])
REFERENCES [dbo].[tbStorage] ([Id])
GO
ALTER TABLE [dbo].[tbImportReceipt] CHECK CONSTRAINT [FK_ImportReceipt_Storage]
GO
ALTER TABLE [dbo].[tbImportReceipt]  WITH CHECK ADD  CONSTRAINT [FK_Product_ImportReceipt] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[tbProduct] ([Id])
GO
ALTER TABLE [dbo].[tbImportReceipt] CHECK CONSTRAINT [FK_Product_ImportReceipt]
GO
ALTER TABLE [dbo].[tbOrders]  WITH CHECK ADD  CONSTRAINT [FK_Order_Address_Id] FOREIGN KEY([Addresses_Id])
REFERENCES [dbo].[tbAddress] ([Id])
GO
ALTER TABLE [dbo].[tbOrders] CHECK CONSTRAINT [FK_Order_Address_Id]
GO
ALTER TABLE [dbo].[tbOrders]  WITH CHECK ADD  CONSTRAINT [FK_Order_Coupon] FOREIGN KEY([Coupon_Id])
REFERENCES [dbo].[tbCoupon] ([Id])
GO
ALTER TABLE [dbo].[tbOrders] CHECK CONSTRAINT [FK_Order_Coupon]
GO
ALTER TABLE [dbo].[tbOrders]  WITH CHECK ADD  CONSTRAINT [FK_Order_Duration] FOREIGN KEY([Duration_Id])
REFERENCES [dbo].[tbDuration] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbOrders] CHECK CONSTRAINT [FK_Order_Duration]
GO
ALTER TABLE [dbo].[tbOrders]  WITH CHECK ADD  CONSTRAINT [FK_Order_Duration_callCharges] FOREIGN KEY([Duration_callCharges_Id])
REFERENCES [dbo].[tbDuration_callCharges] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbOrders] CHECK CONSTRAINT [FK_Order_Duration_callCharges]
GO
ALTER TABLE [dbo].[tbOrders]  WITH CHECK ADD  CONSTRAINT [FK_Order_User] FOREIGN KEY([User_Id])
REFERENCES [dbo].[tbUser] ([Id])
GO
ALTER TABLE [dbo].[tbOrders] CHECK CONSTRAINT [FK_Order_User]
GO
ALTER TABLE [dbo].[tbPackage]  WITH CHECK ADD  CONSTRAINT [FK_Packages_Connect_type] FOREIGN KEY([Connect_type_Id])
REFERENCES [dbo].[tbConnect_type] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbPackage] CHECK CONSTRAINT [FK_Packages_Connect_type]
GO
ALTER TABLE [dbo].[tbPayment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Order] FOREIGN KEY([Order_Id])
REFERENCES [dbo].[tbOrders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbPayment] CHECK CONSTRAINT [FK_Payment_Order]
GO
ALTER TABLE [dbo].[tbProduct]  WITH CHECK ADD  CONSTRAINT [FK_Product_ConnectType] FOREIGN KEY([Connect_type_Id])
REFERENCES [dbo].[tbConnect_type] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbProduct] CHECK CONSTRAINT [FK_Product_ConnectType]
GO
ALTER TABLE [dbo].[tbProduct]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([Supplier_Id])
REFERENCES [dbo].[tbSupplier] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbProduct] CHECK CONSTRAINT [FK_Product_Supplier]
GO
ALTER TABLE [dbo].[tbStorage]  WITH CHECK ADD  CONSTRAINT [FK_Storage_Address_store] FOREIGN KEY([Address_store_id])
REFERENCES [dbo].[tbAddress_store] ([Id])
GO
ALTER TABLE [dbo].[tbStorage] CHECK CONSTRAINT [FK_Storage_Address_store]
GO
ALTER TABLE [dbo].[tbUser]  WITH CHECK ADD  CONSTRAINT [FK_User_Employee] FOREIGN KEY([Employees_Id])
REFERENCES [dbo].[tbEmployee] ([Id])
GO
ALTER TABLE [dbo].[tbUser] CHECK CONSTRAINT [FK_User_Employee]
GO
ALTER TABLE [dbo].[tbUser]  WITH CHECK ADD  CONSTRAINT [FK_User_TpContractor] FOREIGN KEY([TP_contract_Id])
REFERENCES [dbo].[tbTP_contract] ([Id])
GO
ALTER TABLE [dbo].[tbUser] CHECK CONSTRAINT [FK_User_TpContractor]
GO
