using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.account;

namespace nn.friends
{
	// Token: 0x020015C1 RID: 5569
	[Token(Token = "0x2000F4A")]
	public sealed class NotificationQueue : IDisposable
	{
		// Token: 0x06007E91 RID: 32401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F6")]
		[Address(RVA = "0x28583E0", Offset = "0x28584E1", VA = "0x28583E0")]
		public NotificationQueue()
		{
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F7")]
		[Address(RVA = "0x2858450", Offset = "0x2858551", VA = "0x2858450", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F8")]
		[Address(RVA = "0x2858560", Offset = "0x2858661", VA = "0x2858560", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F9")]
		[Address(RVA = "0x2858500", Offset = "0x2858601", VA = "0x2858500")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x0002D510 File Offset: 0x0002B710
		[Token(Token = "0x60068FA")]
		[Address(RVA = "0x2858620", Offset = "0x2858721", VA = "0x2858620")]
		public Result Initialize(Uid uid)
		{
			return default(Result);
		}

		// Token: 0x06007E96 RID: 32406 RVA: 0x0002D528 File Offset: 0x0002B728
		[Token(Token = "0x60068FB")]
		[Address(RVA = "0x2858660", Offset = "0x2858761", VA = "0x2858660")]
		public Result Initialize()
		{
			return default(Result);
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FC")]
		[Address(RVA = "0x28586A0", Offset = "0x28587A1", VA = "0x28586A0")]
		public void Terminate()
		{
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x0002D540 File Offset: 0x0002B740
		[Token(Token = "0x60068FD")]
		[Address(RVA = "0x28586C0", Offset = "0x28587C1", VA = "0x28586C0")]
		public Uid GetUid()
		{
			return default(Uid);
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x0002D558 File Offset: 0x0002B758
		[Token(Token = "0x60068FE")]
		[Address(RVA = "0x28586E0", Offset = "0x28587E1", VA = "0x28586E0")]
		public Result Clear()
		{
			return default(Result);
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x0002D570 File Offset: 0x0002B770
		[Token(Token = "0x60068FF")]
		[Address(RVA = "0x2858720", Offset = "0x2858821", VA = "0x2858720")]
		public Result Pop(ref NotificationInfo outInfo)
		{
			return default(Result);
		}

		// Token: 0x06007E9B RID: 32411 RVA: 0x0002D588 File Offset: 0x0002B788
		[Token(Token = "0x6006900")]
		[Address(RVA = "0x2858760", Offset = "0x2858861", VA = "0x2858760")]
		public bool Exists()
		{
			return default(bool);
		}

		// Token: 0x06007E9C RID: 32412
		[Token(Token = "0x6006901")]
		[Address(RVA = "0x2858440", Offset = "0x2858541", VA = "0x2858440")]
		[PreserveSig]
		private static extern IntPtr Create();

		// Token: 0x06007E9D RID: 32413
		[Token(Token = "0x6006902")]
		[Address(RVA = "0x2858610", Offset = "0x2858711", VA = "0x2858610")]
		[PreserveSig]
		private static extern void Destroy(IntPtr pQueue);

		// Token: 0x06007E9E RID: 32414
		[Token(Token = "0x6006903")]
		[Address(RVA = "0x2858640", Offset = "0x2858741", VA = "0x2858640")]
		[PreserveSig]
		private static extern Result Initialize(IntPtr pQueue, Uid uid);

		// Token: 0x06007E9F RID: 32415
		[Token(Token = "0x6006904")]
		[Address(RVA = "0x2858680", Offset = "0x2858781", VA = "0x2858680")]
		[PreserveSig]
		private static extern Result Initialize(IntPtr pQueue);

		// Token: 0x06007EA0 RID: 32416
		[Token(Token = "0x6006905")]
		[Address(RVA = "0x28586B0", Offset = "0x28587B1", VA = "0x28586B0")]
		[PreserveSig]
		private static extern void Terminate(IntPtr pQueue);

		// Token: 0x06007EA1 RID: 32417
		[Token(Token = "0x6006906")]
		[Address(RVA = "0x28586D0", Offset = "0x28587D1", VA = "0x28586D0")]
		[PreserveSig]
		private static extern Uid GetUid(IntPtr pQueue);

		// Token: 0x06007EA2 RID: 32418
		[Token(Token = "0x6006907")]
		[Address(RVA = "0x2858700", Offset = "0x2858801", VA = "0x2858700")]
		[PreserveSig]
		private static extern Result Clear(IntPtr pQueue);

		// Token: 0x06007EA3 RID: 32419
		[Token(Token = "0x6006908")]
		[Address(RVA = "0x2858740", Offset = "0x2858841", VA = "0x2858740")]
		[PreserveSig]
		private static extern Result Pop(IntPtr pQueue, ref NotificationInfo outInfo);

		// Token: 0x06007EA4 RID: 32420
		[Token(Token = "0x6006909")]
		[Address(RVA = "0x2858780", Offset = "0x2858881", VA = "0x2858780")]
		[PreserveSig]
		private static extern bool Exists(IntPtr pQueue);

		// Token: 0x0401C104 RID: 114948
		[Token(Token = "0x401895D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr queue;
	}
}
