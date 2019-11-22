CREATE DATABASE Task2AudioPlayer_Kiselev;

CREATE TABLE Task2AudioPlayer_Kiselev.dbo.Users(
	UserId int primary key clustered identity(1,1),
	UserLogin nvarchar(50) NOT NULL,
	PasswordHash nvarchar(255) NOT NULL,
	UserFullName nvarchar(255) NOT NULL,
	IsAdmin bit NOT NULL default 0,
	CONSTRAINT AK_Login_Pswd UNIQUE(UserLogin,PasswordHash)
);

CREATE TABLE Task2AudioPlayer_Kiselev.dbo.Genres(
	GenreId  int primary key clustered identity(1,1),
	GenreName nvarchar(50) NOT NULL,
	CONSTRAINT AK_Uniq_Genre UNIQUE(GenreName)
);

CREATE TABLE Task2AudioPlayer_Kiselev.dbo.MusicTracks(
	TrackId  int primary key clustered identity(1,1),
	TrackName nvarchar(50) NOT NULL,
	TrackAuthor nvarchar(50) NOT NULL,
	GenreId int NOT NULL,
	UploadUserId int NOT NULL,
	CONSTRAINT FK_to_Genres_GenreId FOREIGN KEY (GenreId) REFERENCES dbo.Genres(GenreId),
	CONSTRAINT AK_Author_Track UNIQUE(TrackName,TrackAuthor),
	CONSTRAINT FK_to_Users_UserId FOREIGN KEY (UploadUserId) REFERENCES dbo.Users(UserId),
);

CREATE TABLE Task2AudioPlayer_Kiselev.dbo.Playlists(
	PlaylistId int primary key clustered identity(1,1),
	PlaylistName nvarchar(50) NOT NULL,
	PlaylistOwnerId int NOT NULL,
	CONSTRAINT FK_to__Users_UserId FOREIGN KEY (PlaylistOwnerId) REFERENCES dbo.Users(UserId),
	CONSTRAINT AK_PlaylistName_PlaylistOwner UNIQUE(PlaylistName,PlaylistOwnerId)
);

CREATE TABLE Task2AudioPlayer_Kiselev.dbo.TracksAndPlaylists(
	PlaylistId int not null,
	TrackId  int not null,
	CONSTRAINT FK_to_Playlists_PlaylistId FOREIGN KEY (PlaylistId) REFERENCES dbo.Playlists(PlaylistId),
	CONSTRAINT FK_to_MusicTracks_TrackId FOREIGN KEY (TrackId) REFERENCES dbo.MusicTracks(TrackId)
);

