using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DC3 RID: 3523
	[Token(Token = "0x20008F5")]
	public class MP4FileProcessing
	{
		// Token: 0x06005B33 RID: 23347 RVA: 0x0001E018 File Offset: 0x0001C218
		[Token(Token = "0x6004B58")]
		[Address(RVA = "0x2485F30", Offset = "0x2486031", VA = "0x2485F30")]
		public static bool ApplyFastStart(string filePath, bool keepBackup)
		{
			return default(bool);
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x0001E030 File Offset: 0x0001C230
		[Token(Token = "0x6004B59")]
		[Address(RVA = "0x2486350", Offset = "0x2486451", VA = "0x2486350")]
		public static bool ApplyFastStart(string srcPath, string dstPath)
		{
			return default(bool);
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x0001E048 File Offset: 0x0001C248
		[Token(Token = "0x6004B5A")]
		[Address(RVA = "0x2486660", Offset = "0x2486761", VA = "0x2486660")]
		public bool Open(Stream srcStream, Stream dstStream)
		{
			return default(bool);
		}

		// Token: 0x06005B36 RID: 23350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5B")]
		[Address(RVA = "0x2486A30", Offset = "0x2486B31", VA = "0x2486A30")]
		public void Close()
		{
		}

		// Token: 0x06005B37 RID: 23351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B5C")]
		[Address(RVA = "0x2486C80", Offset = "0x2486D81", VA = "0x2486C80")]
		private static MP4FileProcessing.Chunk GetFirstChunkOfType(uint id, List<MP4FileProcessing.Chunk> chunks)
		{
			return null;
		}

		// Token: 0x06005B38 RID: 23352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B5D")]
		[Address(RVA = "0x2486A80", Offset = "0x2486B81", VA = "0x2486A80")]
		private List<MP4FileProcessing.Chunk> ReadChildChunks(MP4FileProcessing.Chunk parentChunk)
		{
			return null;
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B5E")]
		[Address(RVA = "0x24874C0", Offset = "0x24875C1", VA = "0x24874C0")]
		private MP4FileProcessing.Chunk ReadChunkHeader()
		{
			return null;
		}

		// Token: 0x06005B3A RID: 23354 RVA: 0x0001E060 File Offset: 0x0001C260
		[Token(Token = "0x6004B5F")]
		[Address(RVA = "0x2486DA0", Offset = "0x2486EA1", VA = "0x2486DA0")]
		private bool ChunkContainsChildChunkWithId(MP4FileProcessing.Chunk chunk, uint id)
		{
			return default(bool);
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B60")]
		[Address(RVA = "0x2487460", Offset = "0x2487561", VA = "0x2487460")]
		private void WriteChunk(MP4FileProcessing.Chunk chunk)
		{
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B61")]
		[Address(RVA = "0x24878A0", Offset = "0x24879A1", VA = "0x24878A0")]
		private void WriteChunkHeader(MP4FileProcessing.Chunk chunk)
		{
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B62")]
		[Address(RVA = "0x24877A0", Offset = "0x24878A1", VA = "0x24877A0")]
		private void CopyBytes(long numBytes)
		{
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B63")]
		[Address(RVA = "0x2486EB0", Offset = "0x2486FB1", VA = "0x2486EB0")]
		private void WriteChunk_moov(MP4FileProcessing.Chunk parentChunk, ulong byteOffset)
		{
		}

		// Token: 0x06005B3F RID: 23359 RVA: 0x0001E078 File Offset: 0x0001C278
		[Token(Token = "0x6004B64")]
		[Address(RVA = "0x2487660", Offset = "0x2487761", VA = "0x2487660")]
		private uint ReadUInt32()
		{
			return 0U;
		}

		// Token: 0x06005B40 RID: 23360 RVA: 0x0001E090 File Offset: 0x0001C290
		[Token(Token = "0x6004B65")]
		[Address(RVA = "0x2487700", Offset = "0x2487801", VA = "0x2487700")]
		private ulong ReadUInt64()
		{
			return 0UL;
		}

		// Token: 0x06005B41 RID: 23361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B66")]
		[Address(RVA = "0x2487900", Offset = "0x2487A01", VA = "0x2487900")]
		private void WriteUInt32(uint value, bool isBigEndian = true)
		{
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B67")]
		[Address(RVA = "0x24879C0", Offset = "0x2487AC1", VA = "0x24879C0")]
		private void WriteUInt64(ulong value)
		{
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B68")]
		[Address(RVA = "0x2487A70", Offset = "0x2487B71", VA = "0x2487A70")]
		private static string ChunkType(uint id)
		{
			return null;
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x0001E0A8 File Offset: 0x0001C2A8
		[Token(Token = "0x6004B69")]
		[Address(RVA = "0x2487C50", Offset = "0x2487D51", VA = "0x2487C50")]
		private static uint ChunkId(string id)
		{
			return 0U;
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B6A")]
		[Address(RVA = "0x2486650", Offset = "0x2486751", VA = "0x2486650")]
		public MP4FileProcessing()
		{
		}

		// Token: 0x0400BAD1 RID: 47825
		[Token(Token = "0x4008B64")]
		private const int ChunkHeaderSize = 8;

		// Token: 0x0400BAD2 RID: 47826
		[Token(Token = "0x4008B65")]
		private const int CopyBufferSize = 65536;

		// Token: 0x0400BAD3 RID: 47827
		[Token(Token = "0x4008B66")]
		[FieldOffset(Offset = "0x0")]
		private static uint Atom_moov;

		// Token: 0x0400BAD4 RID: 47828
		[Token(Token = "0x4008B67")]
		[FieldOffset(Offset = "0x4")]
		private static uint Atom_mdat;

		// Token: 0x0400BAD5 RID: 47829
		[Token(Token = "0x4008B68")]
		[FieldOffset(Offset = "0x8")]
		private static uint Atom_cmov;

		// Token: 0x0400BAD6 RID: 47830
		[Token(Token = "0x4008B69")]
		[FieldOffset(Offset = "0xC")]
		private static uint Atom_trak;

		// Token: 0x0400BAD7 RID: 47831
		[Token(Token = "0x4008B6A")]
		[FieldOffset(Offset = "0x10")]
		private static uint Atom_mdia;

		// Token: 0x0400BAD8 RID: 47832
		[Token(Token = "0x4008B6B")]
		[FieldOffset(Offset = "0x14")]
		private static uint Atom_minf;

		// Token: 0x0400BAD9 RID: 47833
		[Token(Token = "0x4008B6C")]
		[FieldOffset(Offset = "0x18")]
		private static uint Atom_stbl;

		// Token: 0x0400BADA RID: 47834
		[Token(Token = "0x4008B6D")]
		[FieldOffset(Offset = "0x1C")]
		private static uint Atom_stco;

		// Token: 0x0400BADB RID: 47835
		[Token(Token = "0x4008B6E")]
		[FieldOffset(Offset = "0x20")]
		private static uint Atom_co64;

		// Token: 0x0400BADC RID: 47836
		[Token(Token = "0x4008B6F")]
		[FieldOffset(Offset = "0x10")]
		private BinaryReader _reader;

		// Token: 0x0400BADD RID: 47837
		[Token(Token = "0x4008B70")]
		[FieldOffset(Offset = "0x18")]
		private Stream _writeFile;

		// Token: 0x02000DC4 RID: 3524
		[Token(Token = "0x200143B")]
		private class Chunk
		{
			// Token: 0x06005B47 RID: 23367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A92")]
			[Address(RVA = "0x2487650", Offset = "0x2487751", VA = "0x2487650")]
			public Chunk()
			{
			}

			// Token: 0x0400BADE RID: 47838
			[Token(Token = "0x401BB84")]
			[FieldOffset(Offset = "0x10")]
			public uint id;

			// Token: 0x0400BADF RID: 47839
			[Token(Token = "0x401BB85")]
			[FieldOffset(Offset = "0x18")]
			public long size;

			// Token: 0x0400BAE0 RID: 47840
			[Token(Token = "0x401BB86")]
			[FieldOffset(Offset = "0x20")]
			public long offset;
		}
	}
}
