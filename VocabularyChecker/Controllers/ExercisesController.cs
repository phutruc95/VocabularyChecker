using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VocabularyChecker.Repository;
using VocabularyChecker_Model;
using VocabularyChecker_Model.ViewModel;

namespace VocabularyChecker.Controllers
{
    public class ExercisesController : Controller
    {
        private VocabularyCheckerContext db = new VocabularyCheckerContext();

        // GET: Exercise
        public ActionResult Index()
        {
            List<Exercise> lstExercises = db.Exercises.ToList();
            foreach (var exercise in lstExercises)
            {
                exercise.Content = String.Format(exercise.Content, "<span tabindex=\"" + lstExercises.IndexOf(exercise) + "\"class=\"ex-input\"word-length=\"" + exercise.KeyWord.Count() + "\" id=\"ex" + exercise.ID + "-input\" data-id=\"" + exercise.ID + "\"></span>");
            }
            return View(lstExercises);
        }

        [HttpPost]
        public JsonResult CheckAnswers(List<Answer> answers)
        {
            foreach (Answer answer in answers)
            {
                if (!string.IsNullOrEmpty(answer.KeyWordAnswer))
                {
                    Exercise exercise = db.Exercises.FirstOrDefault(ex => ex.ID == answer.ID);
                    if (exercise != null)
                    {
                        if (answer.KeyWordAnswer.Trim() == exercise.KeyWord.Trim())
                        {
                            answer.IsCorrect = true;
                            continue;
                        }
                    }
                }
                
                answer.IsCorrect = false;
            }
            return Json(answers, JsonRequestBehavior.AllowGet);
        }
    }
}