using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000992 RID: 2450
[Token(Token = "0x200066E")]
public class FesMinimapControl : MonoBehaviour
{
	// Token: 0x0600401E RID: 16414 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600356F")]
	[Address(RVA = "0x21B2100", Offset = "0x21B2201", VA = "0x21B2100")]
	private void Start()
	{
	}

	// Token: 0x0600401F RID: 16415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003570")]
	[Address(RVA = "0x21B2330", Offset = "0x21B2431", VA = "0x21B2330")]
	private void Update()
	{
	}

	// Token: 0x06004020 RID: 16416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003571")]
	[Address(RVA = "0x21B2DF0", Offset = "0x21B2EF1", VA = "0x21B2DF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06004021 RID: 16417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003572")]
	[Address(RVA = "0x21B2280", Offset = "0x21B2381", VA = "0x21B2280")]
	private void MapLoad()
	{
	}

	// Token: 0x06004022 RID: 16418 RVA: 0x00015BB8 File Offset: 0x00013DB8
	[Token(Token = "0x6003573")]
	[Address(RVA = "0x21B2EB0", Offset = "0x21B2FB1", VA = "0x21B2EB0")]
	private float GetDistance(Vector3 worldPos)
	{
		return 0f;
	}

	// Token: 0x06004023 RID: 16419 RVA: 0x00015BD0 File Offset: 0x00013DD0
	[Token(Token = "0x6003574")]
	[Address(RVA = "0x21B2FE0", Offset = "0x21B30E1", VA = "0x21B2FE0")]
	private Vector2 GetPosOnMap(Vector3 worldPos)
	{
		return default(Vector2);
	}

	// Token: 0x06004024 RID: 16420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003575")]
	[Address(RVA = "0x21B2940", Offset = "0x21B2A41", VA = "0x21B2940")]
	private void IconObjSet()
	{
	}

	// Token: 0x06004025 RID: 16421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003576")]
	[Address(RVA = "0x21B2C60", Offset = "0x21B2D61", VA = "0x21B2C60")]
	private void MapRotate()
	{
	}

	// Token: 0x06004026 RID: 16422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003577")]
	[Address(RVA = "0x21B26F0", Offset = "0x21B27F1", VA = "0x21B26F0")]
	private void SetMapFrame()
	{
	}

	// Token: 0x06004027 RID: 16423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003578")]
	[Address(RVA = "0x21B3100", Offset = "0x21B3201", VA = "0x21B3100")]
	public void SetMapSize(int sizeNo)
	{
	}

	// Token: 0x06004028 RID: 16424 RVA: 0x00015BE8 File Offset: 0x00013DE8
	[Token(Token = "0x6003579")]
	[Address(RVA = "0x21B31C0", Offset = "0x21B32C1", VA = "0x21B31C0")]
	public int GetWindowType()
	{
		return 0;
	}

	// Token: 0x06004029 RID: 16425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600357A")]
	[Address(RVA = "0x21B31D0", Offset = "0x21B32D1", VA = "0x21B31D0")]
	public void ChangeMapSize()
	{
	}

	// Token: 0x0600402A RID: 16426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600357B")]
	[Address(RVA = "0x21B33B0", Offset = "0x21B34B1", VA = "0x21B33B0")]
	public void SetNormalScale()
	{
	}

	// Token: 0x0600402B RID: 16427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600357C")]
	[Address(RVA = "0x21B3440", Offset = "0x21B3541", VA = "0x21B3440")]
	public FesMinimapControl()
	{
	}

	// Token: 0x04009E6E RID: 40558
	[Token(Token = "0x4007775")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float DispRange;

	// Token: 0x04009E6F RID: 40559
	[Token(Token = "0x4007776")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform MinimapGroupRect;

	// Token: 0x04009E70 RID: 40560
	[Token(Token = "0x4007777")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform PlayerRect;

	// Token: 0x04009E71 RID: 40561
	[Token(Token = "0x4007778")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private MinimapIconPoint IconPoint;

	// Token: 0x04009E72 RID: 40562
	[Token(Token = "0x4007779")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform NpcIconParent;

	// Token: 0x04009E73 RID: 40563
	[Token(Token = "0x400777A")]
	[FieldOffset(Offset = "0x40")]
	private MinimapIconPoint[] IconObj;

	// Token: 0x04009E74 RID: 40564
	[Token(Token = "0x400777B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Sprite[] miniMapShdrMask;

	// Token: 0x04009E75 RID: 40565
	[Token(Token = "0x400777C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Sprite[] miniMapBgMask;

	// Token: 0x04009E76 RID: 40566
	[Token(Token = "0x400777D")]
	[FieldOffset(Offset = "0x58")]
	private List<Transform> ObjRect;

	// Token: 0x04009E77 RID: 40567
	[Token(Token = "0x400777E")]
	[FieldOffset(Offset = "0x60")]
	private bool RunOnScene;

	// Token: 0x04009E78 RID: 40568
	[Token(Token = "0x400777F")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject[] miniMapFrame;

	// Token: 0x04009E79 RID: 40569
	[Token(Token = "0x4007780")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image[] miniMapMaskImg;

	// Token: 0x04009E7A RID: 40570
	[Token(Token = "0x4007781")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Sprite[] ObjIconSpr;

	// Token: 0x04009E7B RID: 40571
	[Token(Token = "0x4007782")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private FesMiniMapShaderController ShaderCtrl;

	// Token: 0x04009E7C RID: 40572
	[Token(Token = "0x4007783")]
	[FieldOffset(Offset = "0x88")]
	private int windowType;

	// Token: 0x04009E7D RID: 40573
	[Token(Token = "0x4007784")]
	[FieldOffset(Offset = "0x8C")]
	private int step;

	// Token: 0x04009E7E RID: 40574
	[Token(Token = "0x4007785")]
	[FieldOffset(Offset = "0x90")]
	private List<WarpPoints.WarpPoint> WarpableList;

	// Token: 0x04009E7F RID: 40575
	[Token(Token = "0x4007786")]
	[FieldOffset(Offset = "0x98")]
	private int loadPrefabId;

	// Token: 0x04009E80 RID: 40576
	[Token(Token = "0x4007787")]
	[FieldOffset(Offset = "0x9C")]
	private int nowFileNo;

	// Token: 0x04009E81 RID: 40577
	[Token(Token = "0x4007788")]
	[FieldOffset(Offset = "0xA0")]
	private int OBJ_MAX;

	// Token: 0x04009E82 RID: 40578
	[Token(Token = "0x4007789")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Transform[] MinimapParents;

	// Token: 0x04009E83 RID: 40579
	[Token(Token = "0x400778A")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private RectTransform RectTrans;
}
