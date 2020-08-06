﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecordCollection.Models;

namespace RecordCollection.Migrations
{
    [DbContext(typeof(RecordCollectionContext))]
    partial class RecordCollectionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RecordCollection.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("RecordCollection.Models.AlbumArtistGenre", b =>
                {
                    b.Property<int>("AlbumArtistGenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlbumId");

                    b.Property<int?>("ArtistId");

                    b.Property<int?>("GenreId");

                    b.HasKey("AlbumArtistGenreId");

                    b.HasIndex("AlbumId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("AlbumArtistGenre");
                });

            modelBuilder.Entity("RecordCollection.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("RecordCollection.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Name = "Rock"
                        },
                        new
                        {
                            GenreId = 2,
                            Name = "Country"
                        });
                });

            modelBuilder.Entity("RecordCollection.Models.AlbumArtistGenre", b =>
                {
                    b.HasOne("RecordCollection.Models.Album", "Album")
                        .WithMany("ArtistsGenres")
                        .HasForeignKey("AlbumId");

                    b.HasOne("RecordCollection.Models.Artist", "Artist")
                        .WithMany("AlbumsGenres")
                        .HasForeignKey("ArtistId");

                    b.HasOne("RecordCollection.Models.Genre", "Genre")
                        .WithMany("AlbumsArtists")
                        .HasForeignKey("GenreId");
                });
#pragma warning restore 612, 618
        }
    }
}
