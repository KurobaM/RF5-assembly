using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B8D RID: 2957
[Token(Token = "0x20007AC")]
[Attribute(Name = "RequireComponent", RVA = "0x147440", Offset = "0x147541")]
public class RuntimeMeshSimplifier : MonoBehaviour
{
	// Token: 0x170009E7 RID: 2535
	// (get) Token: 0x06004BEB RID: 19435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007E5")]
	public string ProgressTitle
	{
		[Token(Token = "0x6003FA5")]
		[Address(RVA = "0x1EF40D0", Offset = "0x1EF41D1", VA = "0x1EF40D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170009E8 RID: 2536
	// (get) Token: 0x06004BEC RID: 19436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007E6")]
	public string ProgressMessage
	{
		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0x1EF40E0", Offset = "0x1EF41E1", VA = "0x1EF40E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170009E9 RID: 2537
	// (get) Token: 0x06004BED RID: 19437 RVA: 0x00018360 File Offset: 0x00016560
	[Token(Token = "0x170007E7")]
	public int ProgressPercent
	{
		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x1EF40F0", Offset = "0x1EF41F1", VA = "0x1EF40F0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170009EA RID: 2538
	// (get) Token: 0x06004BEE RID: 19438 RVA: 0x00018378 File Offset: 0x00016578
	[Token(Token = "0x170007E8")]
	public bool Finished
	{
		[Token(Token = "0x6003FA8")]
		[Address(RVA = "0x1EF4100", Offset = "0x1EF4201", VA = "0x1EF4100")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06004BEF RID: 19439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FA9")]
	[Address(RVA = "0x1EF4110", Offset = "0x1EF4211", VA = "0x1EF4110")]
	public void Simplify(float percent)
	{
	}

	// Token: 0x06004BF0 RID: 19440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FAA")]
	[Address(RVA = "0x1EF42B0", Offset = "0x1EF43B1", VA = "0x1EF42B0")]
	private void Awake()
	{
	}

	// Token: 0x06004BF1 RID: 19441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FAB")]
	[Address(RVA = "0x1EF4370", Offset = "0x1EF4471", VA = "0x1EF4370")]
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials)
	{
	}

	// Token: 0x06004BF2 RID: 19442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FAC")]
	[Address(RVA = "0x1EF4530", Offset = "0x1EF4631", VA = "0x1EF4530")]
	private void Progress(string strTitle, string strMessage, float fT)
	{
	}

	// Token: 0x06004BF3 RID: 19443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003FAD")]
	[Address(RVA = "0x1EF4220", Offset = "0x1EF4321", VA = "0x1EF4220")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8D30", Offset = "0x1A8E31")]
	private IEnumerator ComputeMeshWithVertices(float fAmount)
	{
		return null;
	}

	// Token: 0x06004BF4 RID: 19444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003FAE")]
	[Address(RVA = "0x1EF4650", Offset = "0x1EF4751", VA = "0x1EF4650")]
	public RuntimeMeshSimplifier()
	{
	}

	// Token: 0x0400ACEF RID: 44271
	[Token(Token = "0x4008277")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<GameObject, Material[]> m_objectMaterials;

	// Token: 0x0400ACF0 RID: 44272
	[Token(Token = "0x4008278")]
	[FieldOffset(Offset = "0x20")]
	private MeshSimplify m_selectedMeshSimplify;

	// Token: 0x0400ACF1 RID: 44273
	[Token(Token = "0x4008279")]
	[FieldOffset(Offset = "0x28")]
	private bool m_bFinished;

	// Token: 0x0400ACF2 RID: 44274
	[Token(Token = "0x400827A")]
	[FieldOffset(Offset = "0x30")]
	private Mesh m_newMesh;

	// Token: 0x0400ACF3 RID: 44275
	[Token(Token = "0x400827B")]
	[FieldOffset(Offset = "0x38")]
	private int m_nLastProgress;

	// Token: 0x0400ACF4 RID: 44276
	[Token(Token = "0x400827C")]
	[FieldOffset(Offset = "0x40")]
	private string m_strLastTitle;

	// Token: 0x0400ACF5 RID: 44277
	[Token(Token = "0x400827D")]
	[FieldOffset(Offset = "0x48")]
	private string m_strLastMessage;

	// Token: 0x02000B8E RID: 2958
	[Token(Token = "0x2001362")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159460", Offset = "0x159561")]
	private sealed class <ComputeMeshWithVertices>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004BF5 RID: 19445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007729")]
		[Address(RVA = "0x1EF4620", Offset = "0x1EF4721", VA = "0x1EF4620")]
		[DebuggerHidden]
		public <ComputeMeshWithVertices>d__12(int <>1__state)
		{
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600772A")]
		[Address(RVA = "0x1EF46D0", Offset = "0x1EF47D1", VA = "0x1EF46D0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x00018390 File Offset: 0x00016590
		[Token(Token = "0x600772B")]
		[Address(RVA = "0x1EF47B0", Offset = "0x1EF48B1", VA = "0x1EF47B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600772C")]
		[Address(RVA = "0x1EF4750", Offset = "0x1EF4851", VA = "0x1EF4750")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBF")]
		private object Current
		{
			[Token(Token = "0x600772D")]
			[Address(RVA = "0x1EF5560", Offset = "0x1EF5661", VA = "0x1EF5560", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600772E")]
		[Address(RVA = "0x1EF5570", Offset = "0x1EF5671", VA = "0x1EF5570", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC0")]
		private object Current
		{
			[Token(Token = "0x600772F")]
			[Address(RVA = "0x1EF55D0", Offset = "0x1EF56D1", VA = "0x1EF55D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400ACF6 RID: 44278
		[Token(Token = "0x401B6D9")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400ACF7 RID: 44279
		[Token(Token = "0x401B6DA")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400ACF8 RID: 44280
		[Token(Token = "0x401B6DB")]
		[FieldOffset(Offset = "0x20")]
		public RuntimeMeshSimplifier <>4__this;

		// Token: 0x0400ACF9 RID: 44281
		[Token(Token = "0x401B6DC")]
		[FieldOffset(Offset = "0x28")]
		public float fAmount;

		// Token: 0x0400ACFA RID: 44282
		[Token(Token = "0x401B6DD")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<GameObject, Material[]>.Enumerator <>7__wrap1;

		// Token: 0x0400ACFB RID: 44283
		[Token(Token = "0x401B6DE")]
		[FieldOffset(Offset = "0x58")]
		private KeyValuePair<GameObject, Material[]> <pair>5__3;

		// Token: 0x0400ACFC RID: 44284
		[Token(Token = "0x401B6DF")]
		[FieldOffset(Offset = "0x68")]
		private MeshSimplify <meshSimplify>5__4;

		// Token: 0x0400ACFD RID: 44285
		[Token(Token = "0x401B6E0")]
		[FieldOffset(Offset = "0x70")]
		private MeshFilter <meshFilter>5__5;

		// Token: 0x0400ACFE RID: 44286
		[Token(Token = "0x401B6E1")]
		[FieldOffset(Offset = "0x78")]
		private SkinnedMeshRenderer <skin>5__6;

		// Token: 0x0400ACFF RID: 44287
		[Token(Token = "0x401B6E2")]
		[FieldOffset(Offset = "0x80")]
		private Mesh <newMesh>5__7;
	}
}
