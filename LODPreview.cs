using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B5F RID: 2911
[Token(Token = "0x2000798")]
public class LODPreview : MonoBehaviour
{
	// Token: 0x06004AD2 RID: 19154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EB1")]
	[Address(RVA = "0x22FC9D0", Offset = "0x22FCAD1", VA = "0x22FC9D0")]
	private void Start()
	{
	}

	// Token: 0x06004AD3 RID: 19155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EB2")]
	[Address(RVA = "0x22FCD60", Offset = "0x22FCE61", VA = "0x22FCD60")]
	private void Progress(string strTitle, string strMessage, float fT)
	{
	}

	// Token: 0x06004AD4 RID: 19156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EB3")]
	[Address(RVA = "0x22FCE50", Offset = "0x22FCF51", VA = "0x22FCE50")]
	private void Update()
	{
	}

	// Token: 0x06004AD5 RID: 19157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EB4")]
	[Address(RVA = "0x22FD390", Offset = "0x22FD491", VA = "0x22FD390")]
	private void OnGUI()
	{
	}

	// Token: 0x06004AD6 RID: 19158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EB5")]
	[Address(RVA = "0x22FCB50", Offset = "0x22FCC51", VA = "0x22FCB50")]
	private void SetActiveObject(int index)
	{
	}

	// Token: 0x06004AD7 RID: 19159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EB6")]
	[Address(RVA = "0x22FE320", Offset = "0x22FE421", VA = "0x22FE320")]
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials)
	{
	}

	// Token: 0x06004AD8 RID: 19160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EB7")]
	[Address(RVA = "0x22FD0B0", Offset = "0x22FD1B1", VA = "0x22FD0B0")]
	private void SetWireframe(bool bEnabled)
	{
	}

	// Token: 0x06004AD9 RID: 19161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003EB8")]
	[Address(RVA = "0x22FE290", Offset = "0x22FE391", VA = "0x22FE290")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8C50", Offset = "0x1A8D51")]
	private IEnumerator ComputeLODWithVertices(float fAmount)
	{
		return null;
	}

	// Token: 0x06004ADA RID: 19162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EB9")]
	[Address(RVA = "0x22FE4F0", Offset = "0x22FE5F1", VA = "0x22FE4F0")]
	public LODPreview()
	{
	}

	// Token: 0x0400AB60 RID: 43872
	[Token(Token = "0x4008159")]
	[FieldOffset(Offset = "0x18")]
	public LODPreview.ShowcaseObject[] ShowcaseObjects;

	// Token: 0x0400AB61 RID: 43873
	[Token(Token = "0x400815A")]
	[FieldOffset(Offset = "0x20")]
	public Material WireframeMaterial;

	// Token: 0x0400AB62 RID: 43874
	[Token(Token = "0x400815B")]
	[FieldOffset(Offset = "0x28")]
	public float MouseSensitvity;

	// Token: 0x0400AB63 RID: 43875
	[Token(Token = "0x400815C")]
	[FieldOffset(Offset = "0x2C")]
	public float MouseReleaseSpeed;

	// Token: 0x0400AB64 RID: 43876
	[Token(Token = "0x400815D")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<GameObject, Material[]> m_objectMaterials;

	// Token: 0x0400AB65 RID: 43877
	[Token(Token = "0x400815E")]
	[FieldOffset(Offset = "0x38")]
	private AutomaticLOD m_selectedAutomaticLOD;

	// Token: 0x0400AB66 RID: 43878
	[Token(Token = "0x400815F")]
	[FieldOffset(Offset = "0x40")]
	private int m_nSelectedIndex;

	// Token: 0x0400AB67 RID: 43879
	[Token(Token = "0x4008160")]
	[FieldOffset(Offset = "0x44")]
	private bool m_bWireframe;

	// Token: 0x0400AB68 RID: 43880
	[Token(Token = "0x4008161")]
	[FieldOffset(Offset = "0x48")]
	private float m_fRotationSpeed;

	// Token: 0x0400AB69 RID: 43881
	[Token(Token = "0x4008162")]
	[FieldOffset(Offset = "0x4C")]
	private float m_fLastMouseX;

	// Token: 0x0400AB6A RID: 43882
	[Token(Token = "0x4008163")]
	[FieldOffset(Offset = "0x50")]
	private Mesh m_newMesh;

	// Token: 0x0400AB6B RID: 43883
	[Token(Token = "0x4008164")]
	[FieldOffset(Offset = "0x58")]
	private int m_nLastProgress;

	// Token: 0x0400AB6C RID: 43884
	[Token(Token = "0x4008165")]
	[FieldOffset(Offset = "0x60")]
	private string m_strLastTitle;

	// Token: 0x0400AB6D RID: 43885
	[Token(Token = "0x4008166")]
	[FieldOffset(Offset = "0x68")]
	private string m_strLastMessage;

	// Token: 0x0400AB6E RID: 43886
	[Token(Token = "0x4008167")]
	[FieldOffset(Offset = "0x70")]
	private float m_fVertexAmount;

	// Token: 0x02000B60 RID: 2912
	[Token(Token = "0x2001348")]
	[Serializable]
	public class ShowcaseObject
	{
		// Token: 0x06004ADB RID: 19163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007704")]
		[Address(RVA = "0x22FEF60", Offset = "0x22FF061", VA = "0x22FEF60")]
		public ShowcaseObject()
		{
		}

		// Token: 0x0400AB6F RID: 43887
		[Token(Token = "0x401B668")]
		[FieldOffset(Offset = "0x10")]
		public AutomaticLOD m_automaticLOD;

		// Token: 0x0400AB70 RID: 43888
		[Token(Token = "0x401B669")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 m_position;

		// Token: 0x0400AB71 RID: 43889
		[Token(Token = "0x401B66A")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 m_angles;

		// Token: 0x0400AB72 RID: 43890
		[Token(Token = "0x401B66B")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 m_rotationAxis;

		// Token: 0x0400AB73 RID: 43891
		[Token(Token = "0x401B66C")]
		[FieldOffset(Offset = "0x40")]
		public string m_description;
	}

	// Token: 0x02000B61 RID: 2913
	[Token(Token = "0x2001349")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159440", Offset = "0x159541")]
	private sealed class <ComputeLODWithVertices>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004ADC RID: 19164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007705")]
		[Address(RVA = "0x22FE4C0", Offset = "0x22FE5C1", VA = "0x22FE4C0")]
		[DebuggerHidden]
		public <ComputeLODWithVertices>d__12(int <>1__state)
		{
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007706")]
		[Address(RVA = "0x22FE590", Offset = "0x22FE691", VA = "0x22FE590", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x00017E20 File Offset: 0x00016020
		[Token(Token = "0x6007707")]
		[Address(RVA = "0x22FE660", Offset = "0x22FE761", VA = "0x22FE660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007708")]
		[Address(RVA = "0x22FE600", Offset = "0x22FE701", VA = "0x22FE600")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBB")]
		private object Current
		{
			[Token(Token = "0x6007709")]
			[Address(RVA = "0x22FEEE0", Offset = "0x22FEFE1", VA = "0x22FEEE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600770A")]
		[Address(RVA = "0x22FEEF0", Offset = "0x22FEFF1", VA = "0x22FEEF0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBC")]
		private object Current
		{
			[Token(Token = "0x600770B")]
			[Address(RVA = "0x22FEF50", Offset = "0x22FF051", VA = "0x22FEF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400AB74 RID: 43892
		[Token(Token = "0x401B66D")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400AB75 RID: 43893
		[Token(Token = "0x401B66E")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400AB76 RID: 43894
		[Token(Token = "0x401B66F")]
		[FieldOffset(Offset = "0x20")]
		public LODPreview <>4__this;

		// Token: 0x0400AB77 RID: 43895
		[Token(Token = "0x401B670")]
		[FieldOffset(Offset = "0x28")]
		public float fAmount;

		// Token: 0x0400AB78 RID: 43896
		[Token(Token = "0x401B671")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<GameObject, Material[]>.Enumerator <>7__wrap1;

		// Token: 0x0400AB79 RID: 43897
		[Token(Token = "0x401B672")]
		[FieldOffset(Offset = "0x58")]
		private AutomaticLOD <automaticLOD>5__3;

		// Token: 0x0400AB7A RID: 43898
		[Token(Token = "0x401B673")]
		[FieldOffset(Offset = "0x60")]
		private MeshFilter <meshFilter>5__4;

		// Token: 0x0400AB7B RID: 43899
		[Token(Token = "0x401B674")]
		[FieldOffset(Offset = "0x68")]
		private SkinnedMeshRenderer <skin>5__5;

		// Token: 0x0400AB7C RID: 43900
		[Token(Token = "0x401B675")]
		[FieldOffset(Offset = "0x70")]
		private Mesh <newMesh>5__6;
	}
}
