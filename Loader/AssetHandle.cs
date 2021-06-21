using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Loader
{
	// Token: 0x02001020 RID: 4128
	[Token(Token = "0x2000A73")]
	public abstract class AssetHandle
	{
		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06006814 RID: 26644 RVA: 0x00023898 File Offset: 0x00021A98
		[Token(Token = "0x17000A64")]
		public static int Count
		{
			[Token(Token = "0x600569C")]
			[Address(RVA = "0x2310C30", Offset = "0x2310D31", VA = "0x2310C30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06006815 RID: 26645 RVA: 0x000238B0 File Offset: 0x00021AB0
		// (set) Token: 0x06006816 RID: 26646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A65")]
		public static bool IsSort
		{
			[Token(Token = "0x600569D")]
			[Address(RVA = "0x2310CB0", Offset = "0x2310DB1", VA = "0x2310CB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD000", Offset = "0x1AD101")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600569E")]
			[Address(RVA = "0x2310D20", Offset = "0x2310E21", VA = "0x2310D20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD010", Offset = "0x1AD111")]
			protected set
			{
			}
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600569F")]
		[Address(RVA = "0x2310D90", Offset = "0x2310E91", VA = "0x2310D90")]
		public static AssetHandle GetHandleList(int id)
		{
			return null;
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x000238C8 File Offset: 0x00021AC8
		[Token(Token = "0x60056A0")]
		[Address(RVA = "0x2310E70", Offset = "0x2310F71", VA = "0x2310E70")]
		public static int Compare(AssetHandle a, AssetHandle b)
		{
			return 0;
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A1")]
		[Address(RVA = "0x2310EA0", Offset = "0x2310FA1", VA = "0x2310EA0")]
		public static void Update()
		{
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A2")]
		[Address(RVA = "0x2310F70", Offset = "0x2311071", VA = "0x2310F70")]
		public static void RemoveAll(int priority = -1)
		{
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A3")]
		[Address(RVA = "0x2311340", Offset = "0x2311441", VA = "0x2311340")]
		public static void SceneUnloadHandles(bool unload = false)
		{
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A4")]
		public static T GetResult<T>(int id) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x0600681D RID: 26653 RVA: 0x000238E0 File Offset: 0x00021AE0
		// (set) Token: 0x0600681E RID: 26654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A66")]
		public AssetHandle.STATE State
		{
			[Token(Token = "0x60056A5")]
			[Address(RVA = "0x2311730", Offset = "0x2311831", VA = "0x2311730")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD020", Offset = "0x1AD121")]
			get
			{
				return AssetHandle.STATE.NONE;
			}
			[Token(Token = "0x60056A6")]
			[Address(RVA = "0x2311740", Offset = "0x2311841", VA = "0x2311740")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD030", Offset = "0x1AD131")]
			protected set
			{
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x0600681F RID: 26655 RVA: 0x000238F8 File Offset: 0x00021AF8
		// (set) Token: 0x06006820 RID: 26656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A67")]
		public int Id
		{
			[Token(Token = "0x60056A7")]
			[Address(RVA = "0x2311750", Offset = "0x2311851", VA = "0x2311750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD040", Offset = "0x1AD141")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60056A8")]
			[Address(RVA = "0x2311760", Offset = "0x2311861", VA = "0x2311760")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD050", Offset = "0x1AD151")]
			protected set
			{
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06006821 RID: 26657 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006822 RID: 26658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A68")]
		public string Key
		{
			[Token(Token = "0x60056A9")]
			[Address(RVA = "0x2311770", Offset = "0x2311871", VA = "0x2311770")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD060", Offset = "0x1AD161")]
			get
			{
				return null;
			}
			[Token(Token = "0x60056AA")]
			[Address(RVA = "0x2311780", Offset = "0x2311881", VA = "0x2311780")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD070", Offset = "0x1AD171")]
			protected set
			{
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06006823 RID: 26659 RVA: 0x00023910 File Offset: 0x00021B10
		// (set) Token: 0x06006824 RID: 26660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A69")]
		public int Priority
		{
			[Token(Token = "0x60056AB")]
			[Address(RVA = "0x2311790", Offset = "0x2311891", VA = "0x2311790")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD080", Offset = "0x1AD181")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60056AC")]
			[Address(RVA = "0x23117A0", Offset = "0x23118A1", VA = "0x23117A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD090", Offset = "0x1AD191")]
			set
			{
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06006825 RID: 26661 RVA: 0x00023928 File Offset: 0x00021B28
		// (set) Token: 0x06006826 RID: 26662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6A")]
		public int Reference
		{
			[Token(Token = "0x60056AD")]
			[Address(RVA = "0x23117B0", Offset = "0x23118B1", VA = "0x23117B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD0A0", Offset = "0x1AD1A1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60056AE")]
			[Address(RVA = "0x23117C0", Offset = "0x23118C1", VA = "0x23117C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD0B0", Offset = "0x1AD1B1")]
			protected set
			{
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06006827 RID: 26663 RVA: 0x00023940 File Offset: 0x00021B40
		// (set) Token: 0x06006828 RID: 26664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6B")]
		public bool SceneOnly
		{
			[Token(Token = "0x60056AF")]
			[Address(RVA = "0x23117D0", Offset = "0x23118D1", VA = "0x23117D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD0C0", Offset = "0x1AD1C1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056B0")]
			[Address(RVA = "0x23117E0", Offset = "0x23118E1", VA = "0x23117E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD0D0", Offset = "0x1AD1D1")]
			protected set
			{
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x00023958 File Offset: 0x00021B58
		// (set) Token: 0x0600682A RID: 26666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6C")]
		public bool IsDone
		{
			[Token(Token = "0x60056B1")]
			[Address(RVA = "0x23117F0", Offset = "0x23118F1", VA = "0x23117F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD0E0", Offset = "0x1AD1E1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056B2")]
			[Address(RVA = "0x2311800", Offset = "0x2311901", VA = "0x2311800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD0F0", Offset = "0x1AD1F1")]
			protected set
			{
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x0600682B RID: 26667 RVA: 0x00023970 File Offset: 0x00021B70
		// (set) Token: 0x0600682C RID: 26668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A6D")]
		public bool IsSuccess
		{
			[Token(Token = "0x60056B3")]
			[Address(RVA = "0x2311810", Offset = "0x2311911", VA = "0x2311810")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD100", Offset = "0x1AD201")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056B4")]
			[Address(RVA = "0x2311820", Offset = "0x2311921", VA = "0x2311820")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD110", Offset = "0x1AD211")]
			protected set
			{
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x0600682D RID: 26669 RVA: 0x00023988 File Offset: 0x00021B88
		[Token(Token = "0x17000A6E")]
		public bool IsLoading
		{
			[Token(Token = "0x60056B5")]
			[Address(RVA = "0x2311830", Offset = "0x2311931", VA = "0x2311830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x0600682E RID: 26670 RVA: 0x000239A0 File Offset: 0x00021BA0
		[Token(Token = "0x17000A6F")]
		public bool IsActive
		{
			[Token(Token = "0x60056B6")]
			[Address(RVA = "0x2311840", Offset = "0x2311941", VA = "0x2311840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B7")]
		[Address(RVA = "0x2311850", Offset = "0x2311951", VA = "0x2311850")]
		protected void Set(int id, SystemLanguage language, int priority, bool scene_only)
		{
		}

		// Token: 0x06006830 RID: 26672
		[Token(Token = "0x60056B8")]
		public abstract void Remove(bool force = false);

		// Token: 0x06006831 RID: 26673
		[Token(Token = "0x60056B9")]
		public abstract bool LoadAsync(bool load = true);

		// Token: 0x06006832 RID: 26674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BA")]
		[Address(RVA = "0x2311AA0", Offset = "0x2311BA1", VA = "0x2311AA0")]
		protected AssetHandle()
		{
		}

		// Token: 0x0400C773 RID: 51059
		[Token(Token = "0x4009403")]
		[FieldOffset(Offset = "0x0")]
		protected static Dictionary<int, AssetHandle> HandleList;

		// Token: 0x0400C774 RID: 51060
		[Token(Token = "0x4009404")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180270", Offset = "0x180371")]
		private static bool <IsSort>k__BackingField;

		// Token: 0x0400C775 RID: 51061
		[Token(Token = "0x4009405")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180280", Offset = "0x180381")]
		private AssetHandle.STATE <State>k__BackingField;

		// Token: 0x0400C776 RID: 51062
		[Token(Token = "0x4009406")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180290", Offset = "0x180391")]
		private int <Id>k__BackingField;

		// Token: 0x0400C777 RID: 51063
		[Token(Token = "0x4009407")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1802A0", Offset = "0x1803A1")]
		private string <Key>k__BackingField;

		// Token: 0x0400C778 RID: 51064
		[Token(Token = "0x4009408")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1802B0", Offset = "0x1803B1")]
		private int <Priority>k__BackingField;

		// Token: 0x0400C779 RID: 51065
		[Token(Token = "0x4009409")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1802C0", Offset = "0x1803C1")]
		private int <Reference>k__BackingField;

		// Token: 0x0400C77A RID: 51066
		[Token(Token = "0x400940A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1802D0", Offset = "0x1803D1")]
		private bool <SceneOnly>k__BackingField;

		// Token: 0x0400C77B RID: 51067
		[Token(Token = "0x400940B")]
		[FieldOffset(Offset = "0x29")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1802E0", Offset = "0x1803E1")]
		private bool <IsDone>k__BackingField;

		// Token: 0x0400C77C RID: 51068
		[Token(Token = "0x400940C")]
		[FieldOffset(Offset = "0x2A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1802F0", Offset = "0x1803F1")]
		private bool <IsSuccess>k__BackingField;

		// Token: 0x02001021 RID: 4129
		[Token(Token = "0x2001519")]
		public enum STATE
		{
			// Token: 0x0400C77E RID: 51070
			[Token(Token = "0x401BF7D")]
			NONE,
			// Token: 0x0400C77F RID: 51071
			[Token(Token = "0x401BF7E")]
			IDLE,
			// Token: 0x0400C780 RID: 51072
			[Token(Token = "0x401BF7F")]
			ENTRY,
			// Token: 0x0400C781 RID: 51073
			[Token(Token = "0x401BF80")]
			LOAD,
			// Token: 0x0400C782 RID: 51074
			[Token(Token = "0x401BF81")]
			Length
		}
	}
}
