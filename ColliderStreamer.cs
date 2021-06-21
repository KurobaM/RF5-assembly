using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000BA6 RID: 2982
[Token(Token = "0x20007BB")]
public class ColliderStreamer : MonoBehaviour
{
	// Token: 0x06004C59 RID: 19545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004006")]
	[Address(RVA = "0x1EA2660", Offset = "0x1EA2761", VA = "0x1EA2660")]
	private void Start()
	{
	}

	// Token: 0x06004C5A RID: 19546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004007")]
	[Address(RVA = "0x1EA2880", Offset = "0x1EA2981", VA = "0x1EA2880")]
	public void SetSceneGameObject(GameObject sceneGameObject)
	{
	}

	// Token: 0x06004C5B RID: 19547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004008")]
	[Address(RVA = "0x1EA28F0", Offset = "0x1EA29F1", VA = "0x1EA28F0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06004C5C RID: 19548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004009")]
	[Address(RVA = "0x1EA29F0", Offset = "0x1EA2AF1", VA = "0x1EA29F0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06004C5D RID: 19549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600400A")]
	[Address(RVA = "0x1EA2B10", Offset = "0x1EA2C11", VA = "0x1EA2B10")]
	private void UnloadScene()
	{
	}

	// Token: 0x06004C5E RID: 19550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600400B")]
	[Address(RVA = "0x1EA2B80", Offset = "0x1EA2C81", VA = "0x1EA2B80")]
	public ColliderStreamer()
	{
	}

	// Token: 0x0400ADC1 RID: 44481
	[Token(Token = "0x40082EA")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x175EA0", Offset = "0x175FA1")]
	public string sceneName;

	// Token: 0x0400ADC2 RID: 44482
	[Token(Token = "0x40082EB")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x175EE0", Offset = "0x175FE1")]
	public string scenePath;

	// Token: 0x0400ADC3 RID: 44483
	[Token(Token = "0x40082EC")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x175F20", Offset = "0x176021")]
	public GameObject sceneGameObject;

	// Token: 0x0400ADC4 RID: 44484
	[Token(Token = "0x40082ED")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HideInInspector", RVA = "0x175F30", Offset = "0x176031")]
	public ColliderStreamerManager colliderStreamerManager;

	// Token: 0x0400ADC5 RID: 44485
	[Token(Token = "0x40082EE")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x175F40", Offset = "0x176041")]
	public bool playerOnlyActivate;

	// Token: 0x0400ADC6 RID: 44486
	[Token(Token = "0x40082EF")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x175F80", Offset = "0x176081")]
	public float unloadTimer;

	// Token: 0x0400ADC7 RID: 44487
	[Token(Token = "0x40082F0")]
	[FieldOffset(Offset = "0x40")]
	private bool loaded;
}
