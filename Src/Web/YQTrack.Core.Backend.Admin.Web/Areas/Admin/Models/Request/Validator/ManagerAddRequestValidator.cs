﻿using FluentValidation;
using YQTrack.Core.Backend.Admin.Web.Common;

namespace YQTrack.Core.Backend.Admin.Web.Areas.Admin.Models.Request.Validator
{
    public class ManagerAddRequestValidator : AbstractValidator<ManagerAddRequest>
    {
        public ManagerAddRequestValidator()
        {
            RuleFor(x => x.NickName).NotNull().NotEmpty().Length(1, 16);
            RuleFor(x => x.Account).NotNull().NotEmpty().Length(1, 16);
            RuleFor(x => x.Password).NotNull().NotEmpty().Length(8, 16).Must(x => AppConfig.PasswordRegex.IsMatch(x)).WithMessage("最少8个字符和最多16个字符至少1个大写字母，1个小写字母，1个数字和1个特殊字符");
            RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password);
            RuleFor(x => x.Remark).NotNull().NotEmpty().Length(1, 32);
        }
    }
}