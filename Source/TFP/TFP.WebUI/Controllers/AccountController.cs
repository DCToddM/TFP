using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TFP.Domain.Abstract;
using TFP.Domain.Entities;
using TFP.WebUI.Models;

namespace TFP.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IAccountsRepository repository;
        public int PageSize = 4;

        public AccountController(IAccountsRepository accountRepository)
        {
            this.repository = accountRepository;
        }

        public ViewResult List(int page = 1)
        {
            vmAccountsList model = new vmAccountsList
            {
                Accounts = repository.Accounts
                .OrderBy(p => p.AccountName)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new vmPageInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Accounts.Count()
                }
            };

            return View(model);
        }
    }
}