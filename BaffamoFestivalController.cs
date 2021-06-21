using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004E9 RID: 1257
[Token(Token = "0x2000398")]
public class BaffamoFestivalController : MonoBehaviour
{
	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x06001ECB RID: 7883 RVA: 0x0000D140 File Offset: 0x0000B340
	// (set) Token: 0x06001ECC RID: 7884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000416")]
	public bool IsPlayerHit
	{
		[Token(Token = "0x6001A68")]
		[Address(RVA = "0x22A0010", Offset = "0x22A0111", VA = "0x22A0010")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F700", Offset = "0x19F801")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001A69")]
		[Address(RVA = "0x22A0020", Offset = "0x22A0121", VA = "0x22A0020")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F710", Offset = "0x19F811")]
		private set
		{
		}
	}

	// Token: 0x170004F1 RID: 1265
	// (get) Token: 0x06001ECD RID: 7885 RVA: 0x0000D158 File Offset: 0x0000B358
	// (set) Token: 0x06001ECE RID: 7886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000417")]
	public bool IsAttack
	{
		[Token(Token = "0x6001A6A")]
		[Address(RVA = "0x22A0030", Offset = "0x22A0131", VA = "0x22A0030")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F720", Offset = "0x19F821")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x22A0040", Offset = "0x22A0141", VA = "0x22A0040")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F730", Offset = "0x19F831")]
		private set
		{
		}
	}

	// Token: 0x170004F2 RID: 1266
	// (get) Token: 0x06001ECF RID: 7887 RVA: 0x0000D170 File Offset: 0x0000B370
	// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000418")]
	public bool IsJudge
	{
		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x22A0050", Offset = "0x22A0151", VA = "0x22A0050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F740", Offset = "0x19F841")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x22A0060", Offset = "0x22A0161", VA = "0x22A0060")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F750", Offset = "0x19F851")]
		set
		{
		}
	}

	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x0000D188 File Offset: 0x0000B388
	// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000419")]
	public float MoveSpeed
	{
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x22A0070", Offset = "0x22A0171", VA = "0x22A0070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F760", Offset = "0x19F861")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x22A0080", Offset = "0x22A0181", VA = "0x22A0080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F770", Offset = "0x19F871")]
		set
		{
		}
	}

	// Token: 0x170004F4 RID: 1268
	// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700041A")]
	public Animator Animator
	{
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x22A0090", Offset = "0x22A0191", VA = "0x22A0090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F780", Offset = "0x19F881")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x22A00A0", Offset = "0x22A01A1", VA = "0x22A00A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F790", Offset = "0x19F891")]
		set
		{
		}
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700041B")]
	public Rigidbody Rigidbody
	{
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x22A00B0", Offset = "0x22A01B1", VA = "0x22A00B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F7A0", Offset = "0x19F8A1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x22A00C0", Offset = "0x22A01C1", VA = "0x22A00C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F7B0", Offset = "0x19F8B1")]
		set
		{
		}
	}

	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
	// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700041C")]
	public float StartActionTime
	{
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x22A00D0", Offset = "0x22A01D1", VA = "0x22A00D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F7C0", Offset = "0x19F8C1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x22A00E0", Offset = "0x22A01E1", VA = "0x22A00E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F7D0", Offset = "0x19F8D1")]
		set
		{
		}
	}

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700041D")]
	public ParticleSystem RushEffect
	{
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x22A00F0", Offset = "0x22A01F1", VA = "0x22A00F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F7E0", Offset = "0x19F8E1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x22A0100", Offset = "0x22A0201", VA = "0x22A0100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F7F0", Offset = "0x19F8F1")]
		set
		{
		}
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A78")]
	[Address(RVA = "0x22A0110", Offset = "0x22A0211", VA = "0x22A0110")]
	private void Update()
	{
	}

	// Token: 0x06001EDC RID: 7900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A79")]
	[Address(RVA = "0x229E0F0", Offset = "0x229E1F1", VA = "0x229E0F0")]
	public void Init()
	{
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0x22A04F0", Offset = "0x22A05F1", VA = "0x22A04F0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0x22A0610", Offset = "0x22A0711", VA = "0x22A0610")]
	private void HitFestivalZone()
	{
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7C")]
	[Address(RVA = "0x22A0700", Offset = "0x22A0801", VA = "0x22A0700")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F800", Offset = "0x19F901")]
	private IEnumerator Attack()
	{
		return null;
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A7D")]
	[Address(RVA = "0x22A02A0", Offset = "0x22A03A1", VA = "0x22A02A0")]
	private void Rush()
	{
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0x22A0470", Offset = "0x22A0571", VA = "0x22A0470")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F870", Offset = "0x19F971")]
	private IEnumerator StartAction()
	{
		return null;
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A7F")]
	[Address(RVA = "0x22A07E0", Offset = "0x22A08E1", VA = "0x22A07E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F8E0", Offset = "0x19F9E1")]
	private IEnumerator OnRushEffect()
	{
		return null;
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A80")]
	[Address(RVA = "0x22A0890", Offset = "0x22A0991", VA = "0x22A0890")]
	public BaffamoFestivalController()
	{
	}

	// Token: 0x040065BD RID: 26045
	[Token(Token = "0x4006042")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1654F0", Offset = "0x1655F1")]
	private bool <IsPlayerHit>k__BackingField;

	// Token: 0x040065BE RID: 26046
	[Token(Token = "0x4006043")]
	[FieldOffset(Offset = "0x19")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165500", Offset = "0x165601")]
	private bool <IsAttack>k__BackingField;

	// Token: 0x040065BF RID: 26047
	[Token(Token = "0x4006044")]
	[FieldOffset(Offset = "0x1A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165510", Offset = "0x165611")]
	private bool <IsJudge>k__BackingField;

	// Token: 0x040065C0 RID: 26048
	[Token(Token = "0x4006045")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165520", Offset = "0x165621")]
	private float <MoveSpeed>k__BackingField;

	// Token: 0x040065C1 RID: 26049
	[Token(Token = "0x4006046")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165530", Offset = "0x165631")]
	private Animator <Animator>k__BackingField;

	// Token: 0x040065C2 RID: 26050
	[Token(Token = "0x4006047")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165540", Offset = "0x165641")]
	private Rigidbody <Rigidbody>k__BackingField;

	// Token: 0x040065C3 RID: 26051
	[Token(Token = "0x4006048")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165550", Offset = "0x165651")]
	private float <StartActionTime>k__BackingField;

	// Token: 0x040065C4 RID: 26052
	[Token(Token = "0x4006049")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165560", Offset = "0x165661")]
	private ParticleSystem <RushEffect>k__BackingField;

	// Token: 0x040065C5 RID: 26053
	[Token(Token = "0x400604A")]
	private const string FESTIVAL_COLLIDER_NAME = "InnerWallCube";

	// Token: 0x040065C6 RID: 26054
	[Token(Token = "0x400604B")]
	private const string PLAYER_TAG = "Player";

	// Token: 0x040065C7 RID: 26055
	[Token(Token = "0x400604C")]
	private const float RUSH_FOOTSTEP_INTERVAL = 0.5f;

	// Token: 0x040065C8 RID: 26056
	[Token(Token = "0x400604D")]
	[FieldOffset(Offset = "0x40")]
	private float countTime;

	// Token: 0x020004EA RID: 1258
	[Token(Token = "0x20010DA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157C00", Offset = "0x157D01")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001EE5 RID: 7909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F4F")]
		[Address(RVA = "0x22A0910", Offset = "0x22A0A11", VA = "0x22A0910")]
		public <>c()
		{
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[Token(Token = "0x6006F50")]
		[Address(RVA = "0x22A0920", Offset = "0x22A0A21", VA = "0x22A0920")]
		internal bool <Attack>b__40_0()
		{
			return default(bool);
		}

		// Token: 0x040065C9 RID: 26057
		[Token(Token = "0x40191EE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BaffamoFestivalController.<>c <>9;

		// Token: 0x040065CA RID: 26058
		[Token(Token = "0x40191EF")]
		[FieldOffset(Offset = "0x8")]
		public static Func<bool> <>9__40_0;
	}

	// Token: 0x020004EB RID: 1259
	[Token(Token = "0x20010DB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157C10", Offset = "0x157D11")]
	private sealed class <Attack>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001EE7 RID: 7911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F51")]
		[Address(RVA = "0x22A0780", Offset = "0x22A0881", VA = "0x22A0780")]
		[DebuggerHidden]
		public <Attack>d__40(int <>1__state)
		{
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F52")]
		[Address(RVA = "0x22A0980", Offset = "0x22A0A81", VA = "0x22A0980", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[Token(Token = "0x6006F53")]
		[Address(RVA = "0x22A0990", Offset = "0x22A0A91", VA = "0x22A0990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C97")]
		private object Current
		{
			[Token(Token = "0x6006F54")]
			[Address(RVA = "0x22A0C60", Offset = "0x22A0D61", VA = "0x22A0C60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F55")]
		[Address(RVA = "0x22A0C70", Offset = "0x22A0D71", VA = "0x22A0C70", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001EEC RID: 7916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C98")]
		private object Current
		{
			[Token(Token = "0x6006F56")]
			[Address(RVA = "0x22A0CD0", Offset = "0x22A0DD1", VA = "0x22A0CD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040065CB RID: 26059
		[Token(Token = "0x40191F0")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040065CC RID: 26060
		[Token(Token = "0x40191F1")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040065CD RID: 26061
		[Token(Token = "0x40191F2")]
		[FieldOffset(Offset = "0x20")]
		public BaffamoFestivalController <>4__this;
	}

	// Token: 0x020004EC RID: 1260
	[Token(Token = "0x20010DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157C20", Offset = "0x157D21")]
	private sealed class <StartAction>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001EED RID: 7917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F57")]
		[Address(RVA = "0x22A07B0", Offset = "0x22A08B1", VA = "0x22A07B0")]
		[DebuggerHidden]
		public <StartAction>d__42(int <>1__state)
		{
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F58")]
		[Address(RVA = "0x22A1020", Offset = "0x22A1121", VA = "0x22A1020", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		[Token(Token = "0x6006F59")]
		[Address(RVA = "0x22A1030", Offset = "0x22A1131", VA = "0x22A1030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C99")]
		private object Current
		{
			[Token(Token = "0x6006F5A")]
			[Address(RVA = "0x22A1100", Offset = "0x22A1201", VA = "0x22A1100", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5B")]
		[Address(RVA = "0x22A1110", Offset = "0x22A1211", VA = "0x22A1110", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9A")]
		private object Current
		{
			[Token(Token = "0x6006F5C")]
			[Address(RVA = "0x22A1170", Offset = "0x22A1271", VA = "0x22A1170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040065CE RID: 26062
		[Token(Token = "0x40191F3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040065CF RID: 26063
		[Token(Token = "0x40191F4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040065D0 RID: 26064
		[Token(Token = "0x40191F5")]
		[FieldOffset(Offset = "0x20")]
		public BaffamoFestivalController <>4__this;
	}

	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20010DD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157C30", Offset = "0x157D31")]
	private sealed class <OnRushEffect>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001EF3 RID: 7923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5D")]
		[Address(RVA = "0x22A0860", Offset = "0x22A0961", VA = "0x22A0860")]
		[DebuggerHidden]
		public <OnRushEffect>d__43(int <>1__state)
		{
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5E")]
		[Address(RVA = "0x22A0CE0", Offset = "0x22A0DE1", VA = "0x22A0CE0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x0000D200 File Offset: 0x0000B400
		[Token(Token = "0x6006F5F")]
		[Address(RVA = "0x22A0CF0", Offset = "0x22A0DF1", VA = "0x22A0CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9B")]
		private object Current
		{
			[Token(Token = "0x6006F60")]
			[Address(RVA = "0x22A0FA0", Offset = "0x22A10A1", VA = "0x22A0FA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F61")]
		[Address(RVA = "0x22A0FB0", Offset = "0x22A10B1", VA = "0x22A0FB0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9C")]
		private object Current
		{
			[Token(Token = "0x6006F62")]
			[Address(RVA = "0x22A1010", Offset = "0x22A1111", VA = "0x22A1010", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040065D1 RID: 26065
		[Token(Token = "0x40191F6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040065D2 RID: 26066
		[Token(Token = "0x40191F7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040065D3 RID: 26067
		[Token(Token = "0x40191F8")]
		[FieldOffset(Offset = "0x20")]
		public BaffamoFestivalController <>4__this;

		// Token: 0x040065D4 RID: 26068
		[Token(Token = "0x40191F9")]
		[FieldOffset(Offset = "0x28")]
		private float <count>5__2;
	}
}
