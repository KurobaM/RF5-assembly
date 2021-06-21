using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.account;

namespace nn.ec
{
	// Token: 0x020015D2 RID: 5586
	[Token(Token = "0x2000F5A")]
	public sealed class ConsumableServiceItemManager : IDisposable
	{
		// Token: 0x06007EFB RID: 32507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006960")]
		[Address(RVA = "0x2853120", Offset = "0x2853221", VA = "0x2853120")]
		public ConsumableServiceItemManager()
		{
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006961")]
		[Address(RVA = "0x2853190", Offset = "0x2853291", VA = "0x2853190", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06007EFD RID: 32509 RVA: 0x0002D6D8 File Offset: 0x0002B8D8
		[Token(Token = "0x6006962")]
		[Address(RVA = "0x2853300", Offset = "0x2853401", VA = "0x2853300")]
		public Result Initialize(ShopServiceAccessor accessor, Uid user)
		{
			return default(Result);
		}

		// Token: 0x06007EFE RID: 32510 RVA: 0x0002D6F0 File Offset: 0x0002B8F0
		[Token(Token = "0x6006963")]
		[Address(RVA = "0x2853360", Offset = "0x2853461", VA = "0x2853360")]
		public Result Initialize(ShopServiceAccessor accessor, Uid user, byte[] buffer)
		{
			return default(Result);
		}

		// Token: 0x06007EFF RID: 32511 RVA: 0x0002D708 File Offset: 0x0002B908
		[Token(Token = "0x6006964")]
		[Address(RVA = "0x28533E0", Offset = "0x28534E1", VA = "0x28533E0")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		// Token: 0x06007F00 RID: 32512 RVA: 0x0002D720 File Offset: 0x0002B920
		[Token(Token = "0x6006965")]
		[Address(RVA = "0x2853420", Offset = "0x2853521", VA = "0x2853420")]
		public bool CanQueryNewData()
		{
			return default(bool);
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x0002D738 File Offset: 0x0002B938
		[Token(Token = "0x6006966")]
		[Address(RVA = "0x2853460", Offset = "0x2853561", VA = "0x2853460")]
		public bool IsConsumptionRequired()
		{
			return default(bool);
		}

		// Token: 0x06007F02 RID: 32514 RVA: 0x0002D750 File Offset: 0x0002B950
		[Token(Token = "0x6006967")]
		[Address(RVA = "0x28534A0", Offset = "0x28535A1", VA = "0x28534A0")]
		public bool IsRecoveryRequired()
		{
			return default(bool);
		}

		// Token: 0x06007F03 RID: 32515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006968")]
		[Address(RVA = "0x28534E0", Offset = "0x28535E1", VA = "0x28534E0")]
		public void SetupAsyncRequest(AsyncGetConsumableRightDataRequest outRequest)
		{
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006969")]
		[Address(RVA = "0x2853530", Offset = "0x2853631", VA = "0x2853530")]
		public void SetupAsyncRequest(AsyncConsumeRightDataRequest outRequest)
		{
		}

		// Token: 0x06007F05 RID: 32517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696A")]
		[Address(RVA = "0x2853580", Offset = "0x2853681", VA = "0x2853580")]
		public void SetupAsyncRequest(AsyncRecoverRightDataRequest outRequest)
		{
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x0002D768 File Offset: 0x0002B968
		[Token(Token = "0x600696B")]
		[Address(RVA = "0x28535D0", Offset = "0x28536D1", VA = "0x28535D0")]
		public long GetRequiredBufferSizeToExportSerializedRightData()
		{
			return 0L;
		}

		// Token: 0x06007F07 RID: 32519 RVA: 0x0002D780 File Offset: 0x0002B980
		[Token(Token = "0x600696C")]
		[Address(RVA = "0x28535F0", Offset = "0x28536F1", VA = "0x28535F0")]
		public long ExportSerializedRightData(byte[] buffer)
		{
			return 0L;
		}

		// Token: 0x06007F08 RID: 32520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600696D")]
		[Address(RVA = "0x2853620", Offset = "0x2853721", VA = "0x2853620")]
		public byte[] ExportSerializedRightData()
		{
			return null;
		}

		// Token: 0x06007F09 RID: 32521 RVA: 0x0002D798 File Offset: 0x0002B998
		[Token(Token = "0x600696E")]
		[Address(RVA = "0x28536B0", Offset = "0x28537B1", VA = "0x28536B0")]
		public int GetProvidableItemIdCount()
		{
			return 0;
		}

		// Token: 0x06007F0A RID: 32522 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		[Token(Token = "0x600696F")]
		[Address(RVA = "0x28536D0", Offset = "0x28537D1", VA = "0x28536D0")]
		public Result GetProvidableItemIds(ref int outItemIdCount, ref ConsumableServiceItemId[] outItemIdArray)
		{
			return default(Result);
		}

		// Token: 0x06007F0B RID: 32523 RVA: 0x0002D7C8 File Offset: 0x0002B9C8
		[Token(Token = "0x6006970")]
		[Address(RVA = "0x2853800", Offset = "0x2853901", VA = "0x2853800")]
		public Result GetProvidableItemIds(out ConsumableServiceItemId[] outItemIdArray)
		{
			return default(Result);
		}

		// Token: 0x06007F0C RID: 32524 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
		[Token(Token = "0x6006971")]
		[Address(RVA = "0x28538A0", Offset = "0x28539A1", VA = "0x28538A0")]
		public Result MarkServiceProvided(ConsumableServiceItemId itemId)
		{
			return default(Result);
		}

		// Token: 0x06007F0D RID: 32525 RVA: 0x0002D7F8 File Offset: 0x0002B9F8
		[Token(Token = "0x6006972")]
		[Address(RVA = "0x2853960", Offset = "0x2853A61", VA = "0x2853960")]
		public Result MarkServiceProvided(ref ulong outSeed, ConsumableServiceItemId itemId)
		{
			return default(Result);
		}

		// Token: 0x06007F0E RID: 32526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006973")]
		[Address(RVA = "0x2853A40", Offset = "0x2853B41", VA = "0x2853A40", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06007F0F RID: 32527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006974")]
		[Address(RVA = "0x2853260", Offset = "0x2853361", VA = "0x2853260")]
		private void _Dispose()
		{
		}

		// Token: 0x06007F10 RID: 32528
		[Token(Token = "0x6006975")]
		[Address(RVA = "0x2853340", Offset = "0x2853441", VA = "0x2853340")]
		[PreserveSig]
		private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user);

		// Token: 0x06007F11 RID: 32529
		[Token(Token = "0x6006976")]
		[Address(RVA = "0x28533B0", Offset = "0x28534B1", VA = "0x28533B0")]
		[PreserveSig]
		private static extern Result Initialize(IntPtr consumableServiceItemManager, ref IntPtr workMemory, IntPtr shopServiceAccessor, Uid user, byte[] buffer, long bufferSize);

		// Token: 0x06007F12 RID: 32530
		[Token(Token = "0x6006977")]
		[Address(RVA = "0x2853400", Offset = "0x2853501", VA = "0x2853400")]
		[PreserveSig]
		private static extern bool IsInitialized(IntPtr consumableServiceItemManager);

		// Token: 0x06007F13 RID: 32531
		[Token(Token = "0x6006978")]
		[Address(RVA = "0x2853440", Offset = "0x2853541", VA = "0x2853440")]
		[PreserveSig]
		private static extern bool CanQueryNewData(IntPtr consumableServiceItemManager);

		// Token: 0x06007F14 RID: 32532
		[Token(Token = "0x6006979")]
		[Address(RVA = "0x2853480", Offset = "0x2853581", VA = "0x2853480")]
		[PreserveSig]
		private static extern bool IsConsumptionRequired(IntPtr consumableServiceItemManager);

		// Token: 0x06007F15 RID: 32533
		[Token(Token = "0x600697A")]
		[Address(RVA = "0x28534C0", Offset = "0x28535C1", VA = "0x28534C0")]
		[PreserveSig]
		private static extern bool IsRecoveryRequired(IntPtr consumableServiceItemManager);

		// Token: 0x06007F16 RID: 32534
		[Token(Token = "0x600697B")]
		[Address(RVA = "0x2853520", Offset = "0x2853621", VA = "0x2853520")]
		[PreserveSig]
		private static extern void SetupAsyncGetConsumableRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncGetConsumableRightDataRequest);

		// Token: 0x06007F17 RID: 32535
		[Token(Token = "0x600697C")]
		[Address(RVA = "0x2853570", Offset = "0x2853671", VA = "0x2853570")]
		[PreserveSig]
		private static extern void SetupAsyncConsumeRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncConsumeRightDataRequest);

		// Token: 0x06007F18 RID: 32536
		[Token(Token = "0x600697D")]
		[Address(RVA = "0x28535C0", Offset = "0x28536C1", VA = "0x28535C0")]
		[PreserveSig]
		private static extern void SetupAsyncRecoverRightDataRequest(IntPtr consumableServiceItemManager, ref IntPtr asyncRecoverRightDataRequest);

		// Token: 0x06007F19 RID: 32537
		[Token(Token = "0x600697E")]
		[Address(RVA = "0x28535E0", Offset = "0x28536E1", VA = "0x28535E0")]
		[PreserveSig]
		private static extern long GetRequiredBufferSizeToExportSerializedRightData(IntPtr consumableServiceItemManager);

		// Token: 0x06007F1A RID: 32538
		[Token(Token = "0x600697F")]
		[Address(RVA = "0x2853610", Offset = "0x2853711", VA = "0x2853610")]
		[PreserveSig]
		private static extern long ExportSerializedRightData(IntPtr consumableServiceItemManager, byte[] buffer, long bufferSize);

		// Token: 0x06007F1B RID: 32539
		[Token(Token = "0x6006980")]
		[Address(RVA = "0x28536C0", Offset = "0x28537C1", VA = "0x28536C0")]
		[PreserveSig]
		private static extern int GetProvidableItemIdCount(IntPtr consumableServiceItemManager);

		// Token: 0x06007F1C RID: 32540
		[Token(Token = "0x6006981")]
		[Address(RVA = "0x2853700", Offset = "0x2853801", VA = "0x2853700")]
		[PreserveSig]
		private static extern Result GetProvidableItemIds(IntPtr consumableServiceItemManager, ref int outItemIdCount, [Out] ConsumableServiceItemId[] outItemIdArray, int itemIdArrayCount);

		// Token: 0x06007F1D RID: 32541
		[Token(Token = "0x6006982")]
		[Address(RVA = "0x2853900", Offset = "0x2853A01", VA = "0x2853900")]
		[PreserveSig]
		private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ConsumableServiceItemId itemId);

		// Token: 0x06007F1E RID: 32542
		[Token(Token = "0x6006983")]
		[Address(RVA = "0x28539D0", Offset = "0x2853AD1", VA = "0x28539D0")]
		[PreserveSig]
		private static extern Result MarkServiceProvided(IntPtr consumableServiceItemManager, ref ulong outSeed, ConsumableServiceItemId itemId);

		// Token: 0x06007F1F RID: 32543
		[Token(Token = "0x6006984")]
		[Address(RVA = "0x2853180", Offset = "0x2853281", VA = "0x2853180")]
		[PreserveSig]
		private static extern void New(ref IntPtr consumableServiceItemManager);

		// Token: 0x06007F20 RID: 32544
		[Token(Token = "0x6006985")]
		[Address(RVA = "0x2853B30", Offset = "0x2853C31", VA = "0x2853B30")]
		[PreserveSig]
		private static extern void Delete(IntPtr consumableServiceItemManager, IntPtr workBuffer);

		// Token: 0x0401C13B RID: 115003
		[Token(Token = "0x4018982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _consumableServiceItemManager;

		// Token: 0x0401C13C RID: 115004
		[Token(Token = "0x4018983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr _workMemory;

		// Token: 0x0401C13D RID: 115005
		[Token(Token = "0x4018984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isDisposed;
	}
}
