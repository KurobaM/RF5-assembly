using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

namespace EventScript
{
	// Token: 0x020010E3 RID: 4323
	[Token(Token = "0x2000ADB")]
	public class LifeCycleScriptManager : MonoBehaviour
	{
		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06006D7D RID: 28029 RVA: 0x00025B90 File Offset: 0x00023D90
		// (set) Token: 0x06006D7E RID: 28030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ADF")]
		public bool IsReady
		{
			[Token(Token = "0x6005ACC")]
			[Address(RVA = "0x21B7F50", Offset = "0x21B8051", VA = "0x21B7F50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE8D0", Offset = "0x1AE9D1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005ACD")]
			[Address(RVA = "0x21B7F60", Offset = "0x21B8061", VA = "0x21B7F60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE8E0", Offset = "0x1AE9E1")]
			private set
			{
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06006D7F RID: 28031 RVA: 0x00025BA8 File Offset: 0x00023DA8
		// (set) Token: 0x06006D80 RID: 28032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE0")]
		public bool IsActive
		{
			[Token(Token = "0x6005ACE")]
			[Address(RVA = "0x21B7F70", Offset = "0x21B8071", VA = "0x21B7F70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE8F0", Offset = "0x1AE9F1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005ACF")]
			[Address(RVA = "0x21B7F80", Offset = "0x21B8081", VA = "0x21B7F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE900", Offset = "0x1AEA01")]
			private set
			{
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06006D81 RID: 28033 RVA: 0x00025BC0 File Offset: 0x00023DC0
		[Token(Token = "0x17000AE1")]
		public static bool Active
		{
			[Token(Token = "0x6005AD0")]
			[Address(RVA = "0x21B7F90", Offset = "0x21B8091", VA = "0x21B7F90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006D82 RID: 28034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD1")]
		[Address(RVA = "0x21B81A0", Offset = "0x21B82A1", VA = "0x21B81A0")]
		public static void Add(ActorID actorID)
		{
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD2")]
		[Address(RVA = "0x21B83C0", Offset = "0x21B84C1", VA = "0x21B83C0")]
		public static void Del(ActorID actorID)
		{
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD3")]
		[Address(RVA = "0x21B8560", Offset = "0x21B8661", VA = "0x21B8560")]
		public static void Play(ActorID actorID)
		{
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD4")]
		[Address(RVA = "0x21B8720", Offset = "0x21B8821", VA = "0x21B8720")]
		public static void PlayAll()
		{
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06006D86 RID: 28038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D87 RID: 28039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE2")]
		public static LifeCycleScriptManager Instance
		{
			[Token(Token = "0x6005AD5")]
			[Address(RVA = "0x21B89A0", Offset = "0x21B8AA1", VA = "0x21B89A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE910", Offset = "0x1AEA11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AD6")]
			[Address(RVA = "0x21B8A10", Offset = "0x21B8B11", VA = "0x21B8A10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE920", Offset = "0x1AEA21")]
			private set
			{
			}
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD7")]
		[Address(RVA = "0x21B8870", Offset = "0x21B8971", VA = "0x21B8870")]
		private void Init()
		{
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD8")]
		[Address(RVA = "0x21B8A80", Offset = "0x21B8B81", VA = "0x21B8A80")]
		private void Quit()
		{
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD9")]
		[Address(RVA = "0x21B8AF0", Offset = "0x21B8BF1", VA = "0x21B8AF0")]
		private void Awake()
		{
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0x21B8BE0", Offset = "0x21B8CE1", VA = "0x21B8BE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0x21B8290", Offset = "0x21B8391", VA = "0x21B8290")]
		private void ScrAdd(ActorID actorID)
		{
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0x21B84F0", Offset = "0x21B85F1", VA = "0x21B84F0")]
		private void ScrDel(ActorID actorID)
		{
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADD")]
		[Address(RVA = "0x21B86A0", Offset = "0x21B87A1", VA = "0x21B86A0")]
		private void ScrPlay(ActorID actorID)
		{
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADE")]
		[Address(RVA = "0x21B8880", Offset = "0x21B8981", VA = "0x21B8880")]
		private void ScrPlay()
		{
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0x21B8DA0", Offset = "0x21B8EA1", VA = "0x21B8DA0")]
		private void Start()
		{
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE0")]
		[Address(RVA = "0x21B8CA0", Offset = "0x21B8DA1", VA = "0x21B8CA0")]
		private void Load(ActorID actorID, int id)
		{
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE1")]
		[Address(RVA = "0x21B8DC0", Offset = "0x21B8EC1", VA = "0x21B8DC0")]
		private void Update()
		{
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0x21B9220", Offset = "0x21B9321", VA = "0x21B9220")]
		public void NpcLifeCycleDataLoad(ActorID actorID, int loaderId, Action callback)
		{
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0x21B9330", Offset = "0x21B9431", VA = "0x21B9330")]
		public LifeCycleScriptManager()
		{
		}

		// Token: 0x04017533 RID: 95539
		[Token(Token = "0x401401A")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ActorID, LifeCycleScriptPlayer> player_;

		// Token: 0x04017534 RID: 95540
		[Token(Token = "0x401401B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811A0", Offset = "0x1812A1")]
		private bool <IsReady>k__BackingField;

		// Token: 0x04017535 RID: 95541
		[Token(Token = "0x401401C")]
		[FieldOffset(Offset = "0x21")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811B0", Offset = "0x1812B1")]
		private bool <IsActive>k__BackingField;

		// Token: 0x04017536 RID: 95542
		[Token(Token = "0x401401D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ActorID, int> DataId;

		// Token: 0x04017537 RID: 95543
		[Token(Token = "0x401401E")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1811C0", Offset = "0x1812C1")]
		private static LifeCycleScriptManager <Instance>k__BackingField;

		// Token: 0x020010E4 RID: 4324
		[Token(Token = "0x2001574")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A0D0", Offset = "0x15A1D1")]
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x06006D96 RID: 28054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D60")]
			[Address(RVA = "0x21B8DB0", Offset = "0x21B8EB1", VA = "0x21B8DB0")]
			public <>c__DisplayClass29_0()
			{
			}

			// Token: 0x06006D97 RID: 28055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D61")]
			[Address(RVA = "0x21B9690", Offset = "0x21B9791", VA = "0x21B9690")]
			internal void <Load>b__0(AssetHandle<TextAsset> handle)
			{
			}

			// Token: 0x04017538 RID: 95544
			[Token(Token = "0x401C125")]
			[FieldOffset(Offset = "0x10")]
			public LifeCycleScriptManager <>4__this;

			// Token: 0x04017539 RID: 95545
			[Token(Token = "0x401C126")]
			[FieldOffset(Offset = "0x18")]
			public ActorID actorID;
		}

		// Token: 0x020010E5 RID: 4325
		[Token(Token = "0x2001575")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A0E0", Offset = "0x15A1E1")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06006D98 RID: 28056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D62")]
			[Address(RVA = "0x21B9320", Offset = "0x21B9421", VA = "0x21B9320")]
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06006D99 RID: 28057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D63")]
			[Address(RVA = "0x21B97D0", Offset = "0x21B98D1", VA = "0x21B97D0")]
			internal void <NpcLifeCycleDataLoad>b__0(AssetHandle<NpcLifeCycleData> handle)
			{
			}

			// Token: 0x0401753A RID: 95546
			[Token(Token = "0x401C127")]
			[FieldOffset(Offset = "0x10")]
			public ActorID actorID;

			// Token: 0x0401753B RID: 95547
			[Token(Token = "0x401C128")]
			[FieldOffset(Offset = "0x14")]
			public int loaderId;

			// Token: 0x0401753C RID: 95548
			[Token(Token = "0x401C129")]
			[FieldOffset(Offset = "0x18")]
			public Action callback;
		}
	}
}
