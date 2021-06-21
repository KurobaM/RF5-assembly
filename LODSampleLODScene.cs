using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B62 RID: 2914
[Token(Token = "0x2000799")]
public class LODSampleLODScene : MonoBehaviour
{
	// Token: 0x06004AE3 RID: 19171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EBA")]
	[Address(RVA = "0x22FEFE0", Offset = "0x22FF0E1", VA = "0x22FEFE0")]
	private void Start()
	{
	}

	// Token: 0x06004AE4 RID: 19172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EBB")]
	[Address(RVA = "0x22FF540", Offset = "0x22FF641", VA = "0x22FF540")]
	private void Update()
	{
	}

	// Token: 0x06004AE5 RID: 19173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EBC")]
	[Address(RVA = "0x22FFAD0", Offset = "0x22FFBD1", VA = "0x22FFAD0")]
	private void OnGUI()
	{
	}

	// Token: 0x06004AE6 RID: 19174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EBD")]
	[Address(RVA = "0x22FF400", Offset = "0x22FF501", VA = "0x22FF400")]
	private void SetActiveCamera(int index)
	{
	}

	// Token: 0x06004AE7 RID: 19175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EBE")]
	[Address(RVA = "0x22FF670", Offset = "0x22FF771", VA = "0x22FF670")]
	private void UpdateCamera(float fPos)
	{
	}

	// Token: 0x06004AE8 RID: 19176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EBF")]
	[Address(RVA = "0x22FF230", Offset = "0x22FF331", VA = "0x22FF230")]
	private void AddMaterials(GameObject theGameObject, Dictionary<GameObject, Material[]> dicMaterials)
	{
	}

	// Token: 0x06004AE9 RID: 19177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EC0")]
	[Address(RVA = "0x22FF7F0", Offset = "0x22FF8F1", VA = "0x22FF7F0")]
	private void SetWireframe(bool bEnabled)
	{
	}

	// Token: 0x06004AEA RID: 19178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EC1")]
	[Address(RVA = "0x2300950", Offset = "0x2300A51", VA = "0x2300950")]
	public LODSampleLODScene()
	{
	}

	// Token: 0x0400AB7D RID: 43901
	[Token(Token = "0x4008168")]
	[FieldOffset(Offset = "0x18")]
	public LODSampleLODScene.SceneCamera[] SceneCameras;

	// Token: 0x0400AB7E RID: 43902
	[Token(Token = "0x4008169")]
	[FieldOffset(Offset = "0x20")]
	public Material WireframeMaterial;

	// Token: 0x0400AB7F RID: 43903
	[Token(Token = "0x400816A")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<GameObject, Material[]> m_objectMaterials;

	// Token: 0x0400AB80 RID: 43904
	[Token(Token = "0x400816B")]
	[FieldOffset(Offset = "0x30")]
	private LODSampleLODScene.SceneCamera m_selectedCamera;

	// Token: 0x0400AB81 RID: 43905
	[Token(Token = "0x400816C")]
	[FieldOffset(Offset = "0x38")]
	private bool m_bWireframe;

	// Token: 0x0400AB82 RID: 43906
	[Token(Token = "0x400816D")]
	[FieldOffset(Offset = "0x40")]
	private List<AutomaticLOD> m_sceneLODObjects;

	// Token: 0x0400AB83 RID: 43907
	[Token(Token = "0x400816E")]
	[FieldOffset(Offset = "0x48")]
	private int m_nMaxLODLevels;

	// Token: 0x0400AB84 RID: 43908
	[Token(Token = "0x400816F")]
	[FieldOffset(Offset = "0x4C")]
	private float m_fCurrentDistanceSlider;

	// Token: 0x0400AB85 RID: 43909
	[Token(Token = "0x4008170")]
	[FieldOffset(Offset = "0x50")]
	private int m_nCamMode;

	// Token: 0x02000B63 RID: 2915
	[Token(Token = "0x200134A")]
	[Serializable]
	public class SceneCamera
	{
		// Token: 0x06004AEB RID: 19179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600770C")]
		[Address(RVA = "0x2300960", Offset = "0x2300A61", VA = "0x2300960")]
		public SceneCamera()
		{
		}

		// Token: 0x0400AB86 RID: 43910
		[Token(Token = "0x401B676")]
		[FieldOffset(Offset = "0x10")]
		public Camera m_camera;

		// Token: 0x0400AB87 RID: 43911
		[Token(Token = "0x401B677")]
		[FieldOffset(Offset = "0x18")]
		public float m_near;

		// Token: 0x0400AB88 RID: 43912
		[Token(Token = "0x401B678")]
		[FieldOffset(Offset = "0x1C")]
		public float m_far;

		// Token: 0x0400AB89 RID: 43913
		[Token(Token = "0x401B679")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HideInInspector", RVA = "0x1957E0", Offset = "0x1958E1")]
		public Vector3 m_v3InitialCameraPosition;

		// Token: 0x0400AB8A RID: 43914
		[Token(Token = "0x401B67A")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "HideInInspector", RVA = "0x1957F0", Offset = "0x1958F1")]
		public Vector3 m_v3ViewDir;
	}
}
