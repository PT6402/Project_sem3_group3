USE [eProject3]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[Banner]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[Feedbacks]    Script Date: 11/01/2024 3:51:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedbacks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [int] NOT NULL,
	[Duration_Id] [int] NULL,
	[Address_Store_Id] [int] NOT NULL,
	[Content] [nvarchar](100) NOT NULL,
	[Reply] [nvarchar](100) NULL,
 CONSTRAINT [PK_Feedbacks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_handler]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbAddress]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbAddress_store]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbCall_charges]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbConnect_type]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbContract_Service]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbCoupon]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbDuration]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbDuration_callCharges]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbEmployee]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbEmployee_type]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbImportReceipt]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbOrders]    Script Date: 11/01/2024 3:51:30 SA ******/
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
	[FeedbackContent] [nvarchar](max) NULL,
	[StatusFeedback] [bit] NOT NULL,
 CONSTRAINT [PK_tbOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPackage]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbPayment]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbProduct]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbStorage]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbSupplier]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbTP_contract]    Script Date: 11/01/2024 3:51:30 SA ******/
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
/****** Object:  Table [dbo].[tbUser]    Script Date: 11/01/2024 3:51:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NULL,
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
 CONSTRAINT [PK_tbUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240108170034_v0', N'7.0.14')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240109181905_v1', N'7.0.14')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240110142048_v2', N'7.0.14')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240110195642_v3', N'7.0.14')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240110200648_v4', N'7.0.14')
GO
SET IDENTITY_INSERT [dbo].[Feedbacks] ON 

INSERT [dbo].[Feedbacks] ([Id], [User_Id], [Duration_Id], [Address_Store_Id], [Content], [Reply]) VALUES (1, 2, 3, 3, N'test feedback', NULL)
SET IDENTITY_INSERT [dbo].[Feedbacks] OFF
GO
SET IDENTITY_INSERT [dbo].[Order_handler] ON 

INSERT [dbo].[Order_handler] ([Id], [Address_store_Id], [Order_Id], [Employee_Id], [StatusHandle]) VALUES (1, 3, N'D0000000000', 5, 1)
SET IDENTITY_INSERT [dbo].[Order_handler] OFF
GO
SET IDENTITY_INSERT [dbo].[tbAddress] ON 

INSERT [dbo].[tbAddress] ([Id], [Address_full], [Phone_code], [Province_code], [District_code], [Ward_code]) VALUES (1, N'Ngo 93,ho tung mau, mai dich, cau giay', N'24', N'1', N'5', N'163')
INSERT [dbo].[tbAddress] ([Id], [Address_full], [Phone_code], [Province_code], [District_code], [Ward_code]) VALUES (2, N'1 cao thang,  thanh binh, hai chau', N'236', N'48', N'492', N'20227')
INSERT [dbo].[tbAddress] ([Id], [Address_full], [Phone_code], [Province_code], [District_code], [Ward_code]) VALUES (3, N'soc trang, long phu, phu huu', N'299', N'94', N'946', N'31657')
INSERT [dbo].[tbAddress] ([Id], [Address_full], [Phone_code], [Province_code], [District_code], [Ward_code]) VALUES (4, N'33 anh thu, ba diem,hoc mon', N'28', N'79', N'784', N'27592')
INSERT [dbo].[tbAddress] ([Id], [Address_full], [Phone_code], [Province_code], [District_code], [Ward_code]) VALUES (5, N'thong nhat , phuong 6 , go vap ', N'28', N'79', N'764', N'26876')
INSERT [dbo].[tbAddress] ([Id], [Address_full], [Phone_code], [Province_code], [District_code], [Ward_code]) VALUES (6, N'94, tan thoi nhat, tan thoi nhat 05,quan 12', N'28', N'79', N'761', N'26791')
SET IDENTITY_INSERT [dbo].[tbAddress] OFF
GO
SET IDENTITY_INSERT [dbo].[tbAddress_store] ON 

INSERT [dbo].[tbAddress_store] ([Id], [Address_Id]) VALUES (1, 1)
INSERT [dbo].[tbAddress_store] ([Id], [Address_Id]) VALUES (2, 2)
INSERT [dbo].[tbAddress_store] ([Id], [Address_Id]) VALUES (3, 3)
INSERT [dbo].[tbAddress_store] ([Id], [Address_Id]) VALUES (4, 4)
INSERT [dbo].[tbAddress_store] ([Id], [Address_Id]) VALUES (5, 5)
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
INSERT [dbo].[tbContract_Service] ([Id], [Order_Id], [TP_Contract_Id], [ContractCode]) VALUES (N'D028000000000001', N'D0000000000', N'D028000000000001', N'D028000000000001')
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

INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (1, 1, 10, CAST(N'2024-01-11T03:06:47.0978028' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (2, 2, 15, CAST(N'2024-01-11T03:06:47.0978046' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (3, 3, 20, CAST(N'2024-01-11T03:06:47.0978047' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (4, 4, 30, CAST(N'2024-01-11T03:06:47.0978048' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (5, 5, 10, CAST(N'2024-01-11T03:06:47.0978049' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (6, 6, 15, CAST(N'2024-01-11T03:06:47.0978050' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (7, 7, 20, CAST(N'2024-01-11T03:06:47.0978052' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (8, 8, 30, CAST(N'2024-01-11T03:06:47.0978053' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (9, 9, 10, CAST(N'2024-01-11T03:06:47.0978054' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (10, 10, 15, CAST(N'2024-01-11T03:06:47.0978055' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (11, 11, 20, CAST(N'2024-01-11T03:06:47.0978057' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (12, 12, 30, CAST(N'2024-01-11T03:06:47.0978058' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (13, 13, 10, CAST(N'2024-01-11T03:06:47.0978059' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (14, 14, 15, CAST(N'2024-01-11T03:06:47.0978060' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (15, 15, 20, CAST(N'2024-01-11T03:06:47.0978061' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (16, 16, 30, CAST(N'2024-01-11T03:06:47.0978062' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (17, 17, 15, CAST(N'2024-01-11T03:06:47.0978063' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (18, 18, 20, CAST(N'2024-01-11T03:06:47.0978065' AS DateTime2), N'Done', 1)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (19, 1, 10, CAST(N'2024-01-11T03:06:47.0978066' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (20, 2, 15, CAST(N'2024-01-11T03:06:47.0978071' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (21, 3, 20, CAST(N'2024-01-11T03:06:47.0978072' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (22, 4, 30, CAST(N'2024-01-11T03:06:47.0978074' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (23, 5, 10, CAST(N'2024-01-11T03:06:47.0978075' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (24, 6, 15, CAST(N'2024-01-11T03:06:47.0978076' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (25, 7, 20, CAST(N'2024-01-11T03:06:47.0978077' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (26, 8, 30, CAST(N'2024-01-11T03:06:47.0978078' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (27, 9, 10, CAST(N'2024-01-11T03:06:47.0978086' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (28, 10, 15, CAST(N'2024-01-11T03:06:47.0978087' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (29, 11, 20, CAST(N'2024-01-11T03:06:47.0978089' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (30, 12, 30, CAST(N'2024-01-11T03:06:47.0978096' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (31, 13, 10, CAST(N'2024-01-11T03:06:47.0978108' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (32, 14, 15, CAST(N'2024-01-11T03:06:47.0978109' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (33, 15, 20, CAST(N'2024-01-11T03:06:47.0978110' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (34, 16, 30, CAST(N'2024-01-11T03:06:47.0978112' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (35, 17, 15, CAST(N'2024-01-11T03:06:47.0978113' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (36, 18, 20, CAST(N'2024-01-11T03:06:47.0978114' AS DateTime2), N'Done', 2)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (37, 1, 10, CAST(N'2024-01-11T03:06:47.0978115' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (38, 2, 14, CAST(N'2024-01-11T03:06:47.0978117' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (39, 3, 20, CAST(N'2024-01-11T03:06:47.0978119' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (40, 4, 30, CAST(N'2024-01-11T03:06:47.0978120' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (41, 5, 10, CAST(N'2024-01-11T03:06:47.0978121' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (42, 6, 15, CAST(N'2024-01-11T03:06:47.0978122' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (43, 7, 20, CAST(N'2024-01-11T03:06:47.0978124' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (44, 8, 30, CAST(N'2024-01-11T03:06:47.0978125' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (45, 9, 10, CAST(N'2024-01-11T03:06:47.0978126' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (46, 10, 15, CAST(N'2024-01-11T03:06:47.0978127' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (47, 11, 20, CAST(N'2024-01-11T03:06:47.0978129' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (48, 12, 30, CAST(N'2024-01-11T03:06:47.0978130' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (49, 13, 10, CAST(N'2024-01-11T03:06:47.0978131' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (50, 14, 15, CAST(N'2024-01-11T03:06:47.0978133' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (51, 15, 20, CAST(N'2024-01-11T03:06:47.0978134' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (52, 16, 30, CAST(N'2024-01-11T03:06:47.0978135' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (53, 17, 15, CAST(N'2024-01-11T03:06:47.0978136' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (54, 18, 20, CAST(N'2024-01-11T03:06:47.0978137' AS DateTime2), N'Done', 3)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (55, 1, 10, CAST(N'2024-01-11T03:06:47.0978138' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (56, 2, 15, CAST(N'2024-01-11T03:06:47.0978139' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (57, 3, 20, CAST(N'2024-01-11T03:06:47.0978140' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (58, 4, 30, CAST(N'2024-01-11T03:06:47.0978142' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (59, 5, 10, CAST(N'2024-01-11T03:06:47.0978143' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (60, 6, 15, CAST(N'2024-01-11T03:06:47.0978144' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (61, 7, 20, CAST(N'2024-01-11T03:06:47.0978145' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (62, 8, 30, CAST(N'2024-01-11T03:06:47.0978149' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (63, 9, 10, CAST(N'2024-01-11T03:06:47.0978151' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (64, 10, 15, CAST(N'2024-01-11T03:06:47.0978152' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (65, 11, 20, CAST(N'2024-01-11T03:06:47.0978153' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (66, 12, 30, CAST(N'2024-01-11T03:06:47.0978154' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (67, 13, 10, CAST(N'2024-01-11T03:06:47.0978155' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (68, 14, 15, CAST(N'2024-01-11T03:06:47.0978157' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (69, 15, 20, CAST(N'2024-01-11T03:06:47.0978158' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (70, 16, 30, CAST(N'2024-01-11T03:06:47.0978159' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (71, 17, 15, CAST(N'2024-01-11T03:06:47.0978160' AS DateTime2), N'Done', 4)
INSERT [dbo].[tbImportReceipt] ([Id], [Product_Id], [Quantity], [Time], [Status], [Storage_id]) VALUES (72, 18, 20, CAST(N'2024-01-11T03:06:47.0978162' AS DateTime2), N'Done', 4)
SET IDENTITY_INSERT [dbo].[tbImportReceipt] OFF
GO
INSERT [dbo].[tbOrders] ([Id], [Status], [Tax], [Total_Price], [Numb_Connect], [CreatedDate], [Coupon_Id], [ContractService_Id], [Duration_callCharges_Id], [Duration_Id], [User_Id], [Addresses_Id], [FeedbackContent], [StatusFeedback]) VALUES (N'D0000000000', N'Finish', N'0,1224', 503.75, 12, CAST(N'2024-01-11T03:39:01.4844005' AS DateTime2), 1, NULL, NULL, 3, 2, 6, N'good service', 1)
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
SET IDENTITY_INSERT [dbo].[tbPayment] ON 

INSERT [dbo].[tbPayment] ([Id], [Order_Id], [DateCreated], [Method_Payment], [Status]) VALUES (1, N'D0000000000', CAST(N'2024-01-11T03:43:26.1479562' AS DateTime2), N'online', 1)
SET IDENTITY_INSERT [dbo].[tbPayment] OFF
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
INSERT [dbo].[tbStorage] ([Id], [Address_store_id]) VALUES (5, 5)
SET IDENTITY_INSERT [dbo].[tbStorage] OFF
GO
SET IDENTITY_INSERT [dbo].[tbSupplier] ON 

INSERT [dbo].[tbSupplier] ([Id], [brandName], [Phone], [Address]) VALUES (1, N'UniFi', N'0462146762', N'ha noi')
INSERT [dbo].[tbSupplier] ([Id], [brandName], [Phone], [Address]) VALUES (2, N'Grandstream', N'0646272131', N'ha noi')
INSERT [dbo].[tbSupplier] ([Id], [brandName], [Phone], [Address]) VALUES (3, N'Panasonic', N'0646272131', N'ha noi')
SET IDENTITY_INSERT [dbo].[tbSupplier] OFF
GO
INSERT [dbo].[tbTP_contract] ([Id], [User_Id]) VALUES (N'D028000000000001', 2)
GO
SET IDENTITY_INSERT [dbo].[tbUser] ON 

INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Status], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id]) VALUES (1, N'Nguyen Van Thien', N'0932859395', NULL, N'Active', N'user', 0xF00B3F5BD99D2C9512AD8FD4E1C54534606E9FD1D4971A64B3448102F0F788F68DF90B45558E3655DC41A1EC92652D170BA14F55E22269D62804232751F444CE, 0xAE78D7ED2AFF285F752544C511D05B97BC06D453463EB15B3077F0CBE9B236DD986E5BD5E192782322F8E828A24CD2D2457915E7783FD04AE7AD806AD0CE94DC168CDA09F98BCB76A2BC8CFF67A54FEA5BA433DDA1051D7634B5BCB5FC84A8BD34778603EB03BEFE61905039E3F91012F71D29E2431F7F831E694361BAAC989C, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Status], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id]) VALUES (2, N'admin', N'0971866177', NULL, NULL, N'admin', 0xF00B3F5BD99D2C9512AD8FD4E1C54534606E9FD1D4971A64B3448102F0F788F68DF90B45558E3655DC41A1EC92652D170BA14F55E22269D62804232751F444CE, 0xAE78D7ED2AFF285F752544C511D05B97BC06D453463EB15B3077F0CBE9B236DD986E5BD5E192782322F8E828A24CD2D2457915E7783FD04AE7AD806AD0CE94DC168CDA09F98BCB76A2BC8CFF67A54FEA5BA433DDA1051D7634B5BCB5FC84A8BD34778603EB03BEFE61905039E3F91012F71D29E2431F7F831E694361BAAC989C, N'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIyIiwidHlwIjoiYWRtaW4iLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9zaWQiOiIyIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiYWRtaW4iLCJleHAiOjE3MDUwMDU4MDMsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6MzAwMCIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3Q6MzAwMCJ9.9FDRzidwilf31K5Z2SDE35w70QFh0aQmJ1ztDTxkCFE', CAST(N'2024-01-10T20:43:23.8840389' AS DateTime2), CAST(N'2024-01-11T20:43:23.8840044' AS DateTime2), NULL, NULL, NULL, N'D028000000000001', NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Status], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id]) VALUES (3, N'Tran Thien Hieu', N'0123456789', NULL, NULL, N'Emp_Sale', 0xF00B3F5BD99D2C9512AD8FD4E1C54534606E9FD1D4971A64B3448102F0F788F68DF90B45558E3655DC41A1EC92652D170BA14F55E22269D62804232751F444CE, 0xAE78D7ED2AFF285F752544C511D05B97BC06D453463EB15B3077F0CBE9B236DD986E5BD5E192782322F8E828A24CD2D2457915E7783FD04AE7AD806AD0CE94DC168CDA09F98BCB76A2BC8CFF67A54FEA5BA433DDA1051D7634B5BCB5FC84A8BD34778603EB03BEFE61905039E3F91012F71D29E2431F7F831E694361BAAC989C, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Status], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id]) VALUES (4, N'Tran Van Phat', N'0987654321', NULL, NULL, N'Emp_Technician', 0xF00B3F5BD99D2C9512AD8FD4E1C54534606E9FD1D4971A64B3448102F0F788F68DF90B45558E3655DC41A1EC92652D170BA14F55E22269D62804232751F444CE, 0xAE78D7ED2AFF285F752544C511D05B97BC06D453463EB15B3077F0CBE9B236DD986E5BD5E192782322F8E828A24CD2D2457915E7783FD04AE7AD806AD0CE94DC168CDA09F98BCB76A2BC8CFF67A54FEA5BA433DDA1051D7634B5BCB5FC84A8BD34778603EB03BEFE61905039E3F91012F71D29E2431F7F831E694361BAAC989C, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Status], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id]) VALUES (5, N'Nguyen Van A', N'0796526595', NULL, NULL, N'Emp_Sale', 0xF00B3F5BD99D2C9512AD8FD4E1C54534606E9FD1D4971A64B3448102F0F788F68DF90B45558E3655DC41A1EC92652D170BA14F55E22269D62804232751F444CE, 0xAE78D7ED2AFF285F752544C511D05B97BC06D453463EB15B3077F0CBE9B236DD986E5BD5E192782322F8E828A24CD2D2457915E7783FD04AE7AD806AD0CE94DC168CDA09F98BCB76A2BC8CFF67A54FEA5BA433DDA1051D7634B5BCB5FC84A8BD34778603EB03BEFE61905039E3F91012F71D29E2431F7F831E694361BAAC989C, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Status], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id]) VALUES (6, N'Nguyen Van B', N'0955797871', NULL, NULL, N'Emp_Sale', 0xF00B3F5BD99D2C9512AD8FD4E1C54534606E9FD1D4971A64B3448102F0F788F68DF90B45558E3655DC41A1EC92652D170BA14F55E22269D62804232751F444CE, 0xAE78D7ED2AFF285F752544C511D05B97BC06D453463EB15B3077F0CBE9B236DD986E5BD5E192782322F8E828A24CD2D2457915E7783FD04AE7AD806AD0CE94DC168CDA09F98BCB76A2BC8CFF67A54FEA5BA433DDA1051D7634B5BCB5FC84A8BD34778603EB03BEFE61905039E3F91012F71D29E2431F7F831E694361BAAC989C, N'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI2IiwidHlwIjoiRW1wX1NhbGUiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9zaWQiOiI2IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiRW1wX1NhbGUiLCJleHAiOjE3MDUwMDU2NTEsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6MzAwMCIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3Q6MzAwMCJ9.4ZvhMBtQcXq-P7BqT8cSVWAR_emwqCogzBHr8s2AWUY', CAST(N'2024-01-10T20:40:51.5888807' AS DateTime2), CAST(N'2024-01-11T20:40:51.5887220' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Status], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id]) VALUES (7, N'Nguyen Van C', N'0689764123', NULL, NULL, N'Emp_Sale', 0xF00B3F5BD99D2C9512AD8FD4E1C54534606E9FD1D4971A64B3448102F0F788F68DF90B45558E3655DC41A1EC92652D170BA14F55E22269D62804232751F444CE, 0xAE78D7ED2AFF285F752544C511D05B97BC06D453463EB15B3077F0CBE9B236DD986E5BD5E192782322F8E828A24CD2D2457915E7783FD04AE7AD806AD0CE94DC168CDA09F98BCB76A2BC8CFF67A54FEA5BA433DDA1051D7634B5BCB5FC84A8BD34778603EB03BEFE61905039E3F91012F71D29E2431F7F831E694361BAAC989C, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Status], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id]) VALUES (8, N'Nguyen Van D', N'0689434167', NULL, NULL, N'Emp_Technician', 0xF00B3F5BD99D2C9512AD8FD4E1C54534606E9FD1D4971A64B3448102F0F788F68DF90B45558E3655DC41A1EC92652D170BA14F55E22269D62804232751F444CE, 0xAE78D7ED2AFF285F752544C511D05B97BC06D453463EB15B3077F0CBE9B236DD986E5BD5E192782322F8E828A24CD2D2457915E7783FD04AE7AD806AD0CE94DC168CDA09F98BCB76A2BC8CFF67A54FEA5BA433DDA1051D7634B5BCB5FC84A8BD34778603EB03BEFE61905039E3F91012F71D29E2431F7F831E694361BAAC989C, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Status], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id]) VALUES (9, N'Nguyen Van E', N'0989764139', NULL, NULL, N'Emp_Technician', 0xF00B3F5BD99D2C9512AD8FD4E1C54534606E9FD1D4971A64B3448102F0F788F68DF90B45558E3655DC41A1EC92652D170BA14F55E22269D62804232751F444CE, 0xAE78D7ED2AFF285F752544C511D05B97BC06D453463EB15B3077F0CBE9B236DD986E5BD5E192782322F8E828A24CD2D2457915E7783FD04AE7AD806AD0CE94DC168CDA09F98BCB76A2BC8CFF67A54FEA5BA433DDA1051D7634B5BCB5FC84A8BD34778603EB03BEFE61905039E3F91012F71D29E2431F7F831E694361BAAC989C, N'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI5IiwidHlwIjoiRW1wX1RlY2huaWNpYW4iLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9zaWQiOiI5IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiRW1wX1RlY2huaWNpYW4iLCJleHAiOjE3MDUwMDU3MzUsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6MzAwMCIsImF1ZCI6Imh0dHA6Ly9sb2NhbGhvc3Q6MzAwMCJ9.Ks3Ux2YFLptBk_uSygloQ1hNFw6C50T3JbfWgU_vgPw', CAST(N'2024-01-10T20:42:15.5107580' AS DateTime2), CAST(N'2024-01-11T20:42:15.5106953' AS DateTime2), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbUser] ([Id], [FullName], [Phone], [Email], [Status], [Role], [PasswordHash], [PasswordSalt], [RefreshToken], [TokenCreated], [TokenExpires], [PasswordReset], [ResetExpires], [MethodReset], [TP_contract_Id], [Employees_Id]) VALUES (10, N'Nguyen Van F', N'0329764195', NULL, NULL, N'Emp_Technician', 0xF00B3F5BD99D2C9512AD8FD4E1C54534606E9FD1D4971A64B3448102F0F788F68DF90B45558E3655DC41A1EC92652D170BA14F55E22269D62804232751F444CE, 0xAE78D7ED2AFF285F752544C511D05B97BC06D453463EB15B3077F0CBE9B236DD986E5BD5E192782322F8E828A24CD2D2457915E7783FD04AE7AD806AD0CE94DC168CDA09F98BCB76A2BC8CFF67A54FEA5BA433DDA1051D7634B5BCB5FC84A8BD34778603EB03BEFE61905039E3F91012F71D29E2431F7F831E694361BAAC989C, N'', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbUser] OFF
GO
ALTER TABLE [dbo].[tbOrders] ADD  DEFAULT (CONVERT([bit],(0))) FOR [StatusFeedback]
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD  CONSTRAINT [FK_FeedBack_Duration] FOREIGN KEY([Duration_Id])
REFERENCES [dbo].[tbDuration] ([Id])
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
