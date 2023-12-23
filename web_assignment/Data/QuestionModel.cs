using System.ComponentModel.DataAnnotations;

namespace web_assignment.Data;

// Entity model to store questions.
public class QuestionModel
{
	public int QuestionModelId { get; set; }

	[StringLength(120, MinimumLength = 3)]
	[Required]
	public string? title { get; set; }

	[StringLength(2000, MinimumLength = 30)]
	[Required]
	public string? content { get; set; }

	[Required]
	public string? correctOption { get; set; }

	[Required]
	public string? optionOne { get; set; }

	[Required]
	public string? optionTwo { get; set; }

	[Required]
	public string? optionThree { get; set; }
}
