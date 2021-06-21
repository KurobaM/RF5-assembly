using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B89 RID: 2953
[Token(Token = "0x20007AA")]
public class SimplifyMeshPreview : MonoBehaviour
{
	// Token: 0x06004BB2 RID: 19378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F74")]
	[Address(RVA = "0x1DE4EF0", Offset = "0x1DE4FF1", VA = "0x1DE4EF0")]
	private void Start()
	{
	}

	// Token: 0x06004BB3 RID: 19379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F75")]
	[Address(RVA = "0x1DE5270", Offset = "0x1DE5371", VA = "0x1DE5270")]
	private void Progress(string strTitle, string strMessage, float fT)
	{
	}

	// Token: 0x06004BB4 RID: 19380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F76")]
	[Address(RVA = "0x1DE5360", Offset = "0x1DE5461", VA = "0x1DE5360")]
	private void Update()
	{
	}

	// Token: 0x06004BB5 RID: 19381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F77")]
	[Address(RVA = "0x1DE58E0", Offset = "0x1DE59E1", VA = "0x1DE58E0")]
	private void OnGUI()
	{
	}

	// Token: 0x06004BB6 RID: 19382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F78")]
	[Address(RVA = "0x1DE5070", Offset = "0x1DE5171", VA = "0x1DE5070")]
	private void SetActiveObject(int index)
	{
	}

	// Token: 0x06004BB7 RID: 19383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F79")]
	[Address(RVA = "0x1DE68B0", Offset = "0x1DE69B1", VA = "0x1DE68B0")]
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials)
	{
	}

	// Token: 0x06004BB8 RID: 19384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F7A")]
	[Address(RVA = "0x1DE5600", Offset = "0x1DE5701", VA = "0x1DE5600")]
	private void SetWireframe(bool bEnabled)
	{
	}

	// Token: 0x06004BB9 RID: 19385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003F7B")]
	[Address(RVA = "0x1DE6820", Offset = "0x1DE6921", VA = "0x1DE6820")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8CC0", Offset = "0x1A8DC1")]
	private IEnumerator ComputeMeshWithVertices(float fAmount)
	{
		return null;
	}

	// Token: 0x06004BBA RID: 19386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003F7C")]
	[Address(RVA = "0x1DE6A80", Offset = "0x1DE6B81", VA = "0x1DE6A80")]
	public SimplifyMeshPreview()
	{
	}

	// Token: 0x0400ACBF RID: 44223
	[Token(Token = "0x4008255")]
	[FieldOffset(Offset = "0x18")]
	public SimplifyMeshPreview.ShowcaseObject[] ShowcaseObjects;

	// Token: 0x0400ACC0 RID: 44224
	[Token(Token = "0x4008256")]
	[FieldOffset(Offset = "0x20")]
	public Material WireframeMaterial;

	// Token: 0x0400ACC1 RID: 44225
	[Token(Token = "0x4008257")]
	[FieldOffset(Offset = "0x28")]
	public float MouseSensitvity;

	// Token: 0x0400ACC2 RID: 44226
	[Token(Token = "0x4008258")]
	[FieldOffset(Offset = "0x2C")]
	public float MouseReleaseSpeed;

	// Token: 0x0400ACC3 RID: 44227
	[Token(Token = "0x4008259")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<GameObject, Material[]> m_objectMaterials;

	// Token: 0x0400ACC4 RID: 44228
	[Token(Token = "0x400825A")]
	[FieldOffset(Offset = "0x38")]
	private MeshSimplify m_selectedMeshSimplify;

	// Token: 0x0400ACC5 RID: 44229
	[Token(Token = "0x400825B")]
	[FieldOffset(Offset = "0x40")]
	private int m_nSelectedIndex;

	// Token: 0x0400ACC6 RID: 44230
	[Token(Token = "0x400825C")]
	[FieldOffset(Offset = "0x44")]
	private bool m_bWireframe;

	// Token: 0x0400ACC7 RID: 44231
	[Token(Token = "0x400825D")]
	[FieldOffset(Offset = "0x48")]
	private float m_fRotationSpeed;

	// Token: 0x0400ACC8 RID: 44232
	[Token(Token = "0x400825E")]
	[FieldOffset(Offset = "0x4C")]
	private float m_fLastMouseX;

	// Token: 0x0400ACC9 RID: 44233
	[Token(Token = "0x400825F")]
	[FieldOffset(Offset = "0x50")]
	private Mesh m_newMesh;

	// Token: 0x0400ACCA RID: 44234
	[Token(Token = "0x4008260")]
	[FieldOffset(Offset = "0x58")]
	private int m_nLastProgress;

	// Token: 0x0400ACCB RID: 44235
	[Token(Token = "0x4008261")]
	[FieldOffset(Offset = "0x60")]
	private string m_strLastTitle;

	// Token: 0x0400ACCC RID: 44236
	[Token(Token = "0x4008262")]
	[FieldOffset(Offset = "0x68")]
	private string m_strLastMessage;

	// Token: 0x0400ACCD RID: 44237
	[Token(Token = "0x4008263")]
	[FieldOffset(Offset = "0x70")]
	private float m_fVertexAmount;

	// Token: 0x0400ACCE RID: 44238
	[Token(Token = "0x4008264")]
	[FieldOffset(Offset = "0x74")]
	private bool m_bGUIEnabled;

	// Token: 0x02000B8A RID: 2954
	[Token(Token = "0x2001360")]
	[Serializable]
	public class ShowcaseObject
	{
		// Token: 0x06004BBB RID: 19387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007721")]
		[Address(RVA = "0x1DE7580", Offset = "0x1DE7681", VA = "0x1DE7580")]
		public ShowcaseObject()
		{
		}

		// Token: 0x0400ACCF RID: 44239
		[Token(Token = "0x401B6CB")]
		[FieldOffset(Offset = "0x10")]
		public MeshSimplify m_meshSimplify;

		// Token: 0x0400ACD0 RID: 44240
		[Token(Token = "0x401B6CC")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 m_position;

		// Token: 0x0400ACD1 RID: 44241
		[Token(Token = "0x401B6CD")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 m_angles;

		// Token: 0x0400ACD2 RID: 44242
		[Token(Token = "0x401B6CE")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 m_rotationAxis;

		// Token: 0x0400ACD3 RID: 44243
		[Token(Token = "0x401B6CF")]
		[FieldOffset(Offset = "0x40")]
		public string m_description;
	}

	// Token: 0x02000B8B RID: 2955
	[Token(Token = "0x2001361")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159450", Offset = "0x159551")]
	private sealed class <ComputeMeshWithVertices>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004BBC RID: 19388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007722")]
		[Address(RVA = "0x1DE6A50", Offset = "0x1DE6B51", VA = "0x1DE6A50")]
		[DebuggerHidden]
		public <ComputeMeshWithVertices>d__12(int <>1__state)
		{
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007723")]
		[Address(RVA = "0x1DE6B30", Offset = "0x1DE6C31", VA = "0x1DE6B30", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x00018180 File Offset: 0x00016380
		[Token(Token = "0x6007724")]
		[Address(RVA = "0x1DE6C00", Offset = "0x1DE6D01", VA = "0x1DE6C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007725")]
		[Address(RVA = "0x1DE6BA0", Offset = "0x1DE6CA1", VA = "0x1DE6BA0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBD")]
		private object Current
		{
			[Token(Token = "0x6007726")]
			[Address(RVA = "0x1DE7500", Offset = "0x1DE7601", VA = "0x1DE7500", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007727")]
		[Address(RVA = "0x1DE7510", Offset = "0x1DE7611", VA = "0x1DE7510", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06004BC2 RID: 19394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBE")]
		private object Current
		{
			[Token(Token = "0x6007728")]
			[Address(RVA = "0x1DE7570", Offset = "0x1DE7671", VA = "0x1DE7570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400ACD4 RID: 44244
		[Token(Token = "0x401B6D0")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400ACD5 RID: 44245
		[Token(Token = "0x401B6D1")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400ACD6 RID: 44246
		[Token(Token = "0x401B6D2")]
		[FieldOffset(Offset = "0x20")]
		public SimplifyMeshPreview <>4__this;

		// Token: 0x0400ACD7 RID: 44247
		[Token(Token = "0x401B6D3")]
		[FieldOffset(Offset = "0x28")]
		public float fAmount;

		// Token: 0x0400ACD8 RID: 44248
		[Token(Token = "0x401B6D4")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<GameObject, Material[]>.Enumerator <>7__wrap1;

		// Token: 0x0400ACD9 RID: 44249
		[Token(Token = "0x401B6D5")]
		[FieldOffset(Offset = "0x58")]
		private MeshSimplify <meshSimplify>5__3;

		// Token: 0x0400ACDA RID: 44250
		[Token(Token = "0x401B6D6")]
		[FieldOffset(Offset = "0x60")]
		private MeshFilter <meshFilter>5__4;

		// Token: 0x0400ACDB RID: 44251
		[Token(Token = "0x401B6D7")]
		[FieldOffset(Offset = "0x68")]
		private SkinnedMeshRenderer <skin>5__5;

		// Token: 0x0400ACDC RID: 44252
		[Token(Token = "0x401B6D8")]
		[FieldOffset(Offset = "0x70")]
		private Mesh <newMesh>5__6;
	}
}
