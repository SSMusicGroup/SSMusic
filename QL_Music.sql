USE [QL_Music]
GO
/****** Object:  Database [QL_Music]    Script Date: 13/08/2020 3:11:40 SA ******/
ALTER DATABASE [QL_Music] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_Music].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_Music] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_Music] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_Music] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_Music] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_Music] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_Music] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_Music] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_Music] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_Music] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_Music] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_Music] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_Music] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_Music] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_Music] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_Music] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_Music] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_Music] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_Music] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_Music] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_Music] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_Music] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_Music] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_Music] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_Music] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_Music] SET  MULTI_USER 
GO
ALTER DATABASE [QL_Music] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_Music] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_Music] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_Music] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_Music]
GO
/****** Object:  Table [dbo].[BaiHat]    Script Date: 13/08/2020 3:11:40 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiHat](
	[maBaiHat] [nchar](10) NOT NULL,
	[tenBaiHat] [nvarchar](255) NULL,
	[maCaSi] [nchar](10) NULL,
	[pathBaiHat] [nvarchar](255) NULL,
 CONSTRAINT [PK_BaiHat] PRIMARY KEY CLUSTERED 
(
	[maBaiHat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BaiHatVaPlayList]    Script Date: 13/08/2020 3:11:40 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiHatVaPlayList](
	[maBaiHat] [nchar](10) NOT NULL,
	[maPlaylist] [nchar](10) NOT NULL,
 CONSTRAINT [PK_BaiHatVaPlayList] PRIMARY KEY CLUSTERED 
(
	[maBaiHat] ASC,
	[maPlaylist] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CaSi]    Script Date: 13/08/2020 3:11:40 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaSi](
	[maCaSi] [nchar](10) NOT NULL,
	[tenCaSi] [nvarchar](50) NULL,
 CONSTRAINT [PK_CaSi] PRIMARY KEY CLUSTERED 
(
	[maCaSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Playlist]    Script Date: 13/08/2020 3:11:40 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Playlist](
	[maPlaylist] [nchar](10) NOT NULL,
	[tenPlaylist] [nvarchar](50) NULL,
 CONSTRAINT [PK_PlayList] PRIMARY KEY CLUSTERED 
(
	[maPlaylist] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH001     ', N'Duong mot chieu.mp3', N'CS001     ', N'E:\Duong mot chieu.mp3                                                                              ')
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH0010    ', N'Nguoi-Yeu-Cua-Em-Truong-Thao-Nhi.mp3', NULL, N'E:\Nhạc\Nguoi-Yeu-Cua-Em-Truong-Thao-Nhi.mp3')
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH0011    ', N'Ex''s Hate Me - B Ray x Masew (Ft AMEE) - Official MV.mp3', NULL, N'E:\Nhạc\Ex''s Hate Me - B Ray x Masew (Ft AMEE) - Official MV.mp3')
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH002     ', N'How-To-Love-Cash-Cash.mp3', N'CS001     ', N'E:\Nhạc\How-To-Love-Cash-Cash.mp3                                                                   ')
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH003     ', N'Noi-Nay-Co-Anh-Son-Tung-M-TP.mp3', N'CS001     ', N'E:\Nhạc\Noi-Nay-Co-Anh-Son-Tung-M-TP.mp3                                                            ')
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH004     ', N'Solo-Dance-Martin-Jensen.mp3', NULL, N'E:\Nhạc\Solo-Dance-Martin-Jensen.mp3                                                                ')
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH005     ', N'Tuy-Am-Xesi-Masew-Nhat-Nguyen.mp3', NULL, N'E:\Nhạc\Tuy-Am-Xesi-Masew-Nhat-Nguyen.mp3                                                           ')
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH006     ', N'Tuyển tập 30 bài nhạc Hoa tuyển chọn hay nhất.mp3', NULL, N'E:\Nhạc\Tuyển tập 30 bài nhạc Hoa tuyển chọn hay nhất.mp3                                           ')
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH007     ', N'Nhạc Bất Hủ Thập Niên 80 (Vol 2).mp3', NULL, N'E:\Nhạc\Nhạc Bất Hủ Thập Niên 80 (Vol 2).mp3                                                        ')
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH008     ', N'Nhạc Ngoại Bất Hủ Thập Niên 80 (Vol 1) - By Chau Thanh Lee..mp3', NULL, N'E:\Nhạc\Nhạc Ngoại Bất Hủ Thập Niên 80 (Vol 1) - By Chau Thanh Lee..mp3')
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat]) VALUES (N'BH009     ', N'♪ Đường Một Chiều ‣ Những Bản Acoustic Hay Nhất Về Tình Yêu Đơn Phương Thầm Lặng.mp3', NULL, N'E:\Nhạc\♪ Đường Một Chiều ‣ Những Bản Acoustic Hay Nhất Về Tình Yêu Đơn Phương Thầm Lặng.mp3')
INSERT [dbo].[CaSi] ([maCaSi], [tenCaSi]) VALUES (N'CS001     ', N'Sơn Tùng MTP')
INSERT [dbo].[Playlist] ([maPlaylist], [tenPlaylist]) VALUES (N'PL001     ', N'Hay nghe')
ALTER TABLE [dbo].[BaiHat]  WITH CHECK ADD  CONSTRAINT [FK_BaiHat_CaSi] FOREIGN KEY([maCaSi])
REFERENCES [dbo].[CaSi] ([maCaSi])
GO
ALTER TABLE [dbo].[BaiHat] CHECK CONSTRAINT [FK_BaiHat_CaSi]
GO
ALTER TABLE [dbo].[BaiHatVaPlayList]  WITH CHECK ADD  CONSTRAINT [FK_BaiHatVaPlayList_BaiHat] FOREIGN KEY([maBaiHat])
REFERENCES [dbo].[BaiHat] ([maBaiHat])
GO
ALTER TABLE [dbo].[BaiHatVaPlayList] CHECK CONSTRAINT [FK_BaiHatVaPlayList_BaiHat]
GO
ALTER TABLE [dbo].[BaiHatVaPlayList]  WITH CHECK ADD  CONSTRAINT [FK_BaiHatVaPlayList_Playlist] FOREIGN KEY([maPlaylist])
REFERENCES [dbo].[Playlist] ([maPlaylist])
GO
ALTER TABLE [dbo].[BaiHatVaPlayList] CHECK CONSTRAINT [FK_BaiHatVaPlayList_Playlist]
GO
USE [master]
GO
ALTER DATABASE [QL_Music] SET  READ_WRITE 
GO
