using Ijuba.Webapi.Application.IMS.Invoice;
using Microsoft.Identity.Client;

namespace Ijuba.Webapi.Host.Controllers.PDF;

public class PDFTemplate
{
    public string CashTillRecon()
    {
        var html = @"

<!DOCTYPE html>
<html>
<head>
  <title>Cash Till Reconciliation</title>
  <!-- Include Bootstrap CSS -->
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"">
</head>
<body>
<div class=""container bootdey"">
<div class=""row invoice row-printable"">
    <div class=""col-md-10"">
        <!-- col-lg-12 start here -->
        <div class=""panel panel-default plain "" id=""dash_0"">
            <!-- Start .panel -->	
            <div class=""panel-body p30 bg-warning"">
                <div class=""col-md-12"">
				<div class=""col-lg-12"" >
				 <div class=""row  bg-primary"">
                    <!-- Start .row -->
                    <div class=""col-xs-6 "">
                        <!-- col-lg-6 start here -->
                        <div class=""invoice-logo""><img width=""100"" src=""D:\Source Codes\Vezo\VEZO\VEZOWasm\Server\Images\download.png"" alt=""Invoice logo""></div>
                    </div>
                    <!-- col-lg-6 end here -->
                    <div class=""col-xs-6 "">
                        <!-- col-lg-6 start here -->
                        <div class=""invoice-from "">
                            <ul class=""list-unstyled text-right"">
                                <li><strong>NishYur Logistics TA SAITRANS HAULERS</strong></li>
                                <li>27 Railway Street</li>
                                <li>Kok Stad</li>
                                <li>4700</li>
								<li></li>
                            </ul>
                        </div>
                    </div>
                    <!-- col-lg-6 end here -->
				</div>
				</div>
				</div>
				
				<div class='row mb-3'>
					<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
					</div>
						
                    <div class=""col-md-12"">
                        <!-- col-lg-12 start here -->
					<div class=""col-lg-12"" >	
						<div class=""row bg-warning"">
						
						<div class=""col-xs-4 from"">
							<ul class=""list-unstyled mb0"">
								<li><strong>For User:</strong> NDU</li>
								<li><strong>Till Acc:</strong> 32060</li>
								<li><strong>Date From:</strong> 24 Jul 23 - 24 Jul 23 </li>
							</ul>
						</div>

						<div class=""col-xs-4 "">
							<p class=""lead marginbottom""></p>
							<p></p>
							<p class=""text-center""><H5><strong>Cash Till Reconciliation</strong></H5></p>
							<p></p>
							<p></p>
							<p></p>

						</div>
						<div class=""col-xs-4 "">
							<ul class=""list-unstyled mb0"">

								<li><strong>Type:</strong> Totals Only</li>
								<li><strong>Vendor No:</strong></li>
								<li><strong>Date Printed</strong> 24 Jul 23<span class=""label label-danger""></span></li>
								
							</ul>
						
						</div>
					</div>

			
			
			<div class=""invoice-footer mt25"">
			<div class=""col-lg-12"">			
				<div class=""row bg-primary"" >
				
					<div class=""col-xs-1 from bg-primary"" >
						<ul class=""list-unstyled mb0 text-left"">
							<li style=""font-size: 12px;"">USR</li>
						</ul>
					</div>
				
					<div class=""col-xs-1 from bg-primary"" >
						<ul class=""list-unstyled mb0 text-left"">
							<li style=""font-size: 12px;"">Rep</li>
						</ul>
					</div>
					
					<div class=""col-xs-1 from bg-primary"" >
						<ul class=""list-unstyled mb0 text-left"">
							<li style=""font-size: 12px;"">L</li>
						</ul>
					</div>
		
					<div class=""col-xs-1 from bg-primary"" >
						<ul class=""list-unstyled mb0 text-left"">
							<li style=""font-size: 12px;"">AccNo</li>
						</ul>
					</div>

				    <div class=""col-xs-1 from bg-primary"" >
						<ul class=""list-unstyled mb0 text-left"">
							<li style=""font-size: 12px;"">Date</li>
						</ul>
					</div>
					
					<div class=""col-xs-1 from bg-primary"" >
						<ul class=""list-unstyled mb0 text-left"">
							<li style=""font-size: 12px;"">TP</li>
						</ul>
					</div>
					<div class=""col-xs-1 from bg-primary"" >
						<ul class=""list-unstyled mb0 text-left"">
							<li style=""font-size: 12px;"">RefCode</li>
						</ul>
					</div>
					<div class=""col-xs-1 from bg-primary"" >
						<ul class=""list-unstyled mb0 text-left"">
							<li style=""font-size: 12px;"">Amount</li>
						</ul>
					</div>
					<div class=""col-xs-1 from bg-primary"" >
						<ul class=""list-unstyled mb0 text-left"">
							<li style=""font-size: 12px;"">Description</li>
						</ul>
					</div>
					
					<div class=""col-xs-1 from bg-primary"" >
						<ul class=""list-unstyled mb0 text-left"">
							<li style=""font-size: 12px;"">PostDate</li>
						</ul>
					</div>
				</div>
			</div>
			</div>

			<div class=""card"" >
			  <div class=""card-body"">
				<h5 class=""card-title""><strong>TILL TOTALS for USER 1 - NDU</strong></h5>
				<p class=""card-text"">As an added protection against till fraud, the first column lists the Totals from the Till Control file for the selected date(s).
							The second column  lists Totals calculated now from the actual transactions posted on the selected date(s)
							If there was Mixed Tender on some postings, some of the totals (Cheques, Cash, etc) ,ay not agree, but the Till Totals should agree.
				</p>
				
			  </div>
			</div>
			
			

			<div class=""col-lg-12"">			
				<div class=""row text-secondary"" >
					<div class=""invoice-items bg-warning "">
                            <div    tabindex=""0"" class=""col-xs-8 text-secondary"">
							
								<table class=""table table-bordered bg-info text-secondary"">
								<tr style=""height:85px;"">
										<td><h4><strong>Till Totals for the selected date(s)</strong></h4>
										</td>
									</tr>
									<tr>
										<td > CASH FLOAT
										</td>
										<td>0.00
										</td>
									</tr>
									<tr>
										<td> CASH 
										</td>
										<td>4600.00
										</td>
									</tr>
									<tr>
										<td> Cheques 
										</td>
										<td>0.00
										</td>
									</tr>
									<tr>
										<td> Credit Cards 
										</td>
										<td>0.00
										</td>
									</tr>
									<tr>
										<td> Electronic Transfers 
										</td>
										<td>0.00
										</td>
									</tr>
									<tr>
										<td> Vouchers 
										</td>
										<td>0.00
										</td>
									</tr>
									
									<tr>
										<td> Other 
										</td>
										<td>0.00
										</td>
									</tr>
									<tr>
										<td> Mixed Tender 
										</td>
										<td>0.00
										</td>
									</tr>
									
									<tr>
										<td> <strong>Total in Till</strong> 
										</td>
										<td><strong>4600.00</strong>
										</td>
									</tr>
								</table>
							</div>
							
							 <div  style=""overflow: hidden; outline: none;"" tabindex=""0"" class=""col-xs-4 text-secondary"">
								
								<table class=""table table-bordered bg-info text-secondary"">
									<tr style=""height:85px;"">
										
										<td><h5><strong>Totals based on the actual transaction entries</strong></h5>
										</td>
									</tr>
								
									<tr>
										
										<td>0.00
										</td>
									</tr>
									<tr>
										
										<td>4600.00
										</td>
									</tr>
									<tr>
										
										<td>0.00
										</td>
									</tr>
									<tr>
										
										<td>0.00
										</td>
									</tr>
									<tr>
										
										<td>0.00
										</td>
									</tr>
									<tr>
										
										<td>0.00
										</td>
									</tr>
									
									<tr>
										
										<td>0.00
										</td>
									</tr>
									<tr>
										
										<td>0.00
										</td>
									</tr>
									
									<tr>
										
										<td><strong>4600.00</strong>
										</td>
									</tr>
								</table>
							</div>
					</div>
				</div>
			</div>
			
			<div class=""col-lg-12"">			
				<div class=""row text-secondary"" >
					<div class=""invoice-items bg-warning "">
                            <div    tabindex=""0"" class=""col-xs-8 text-secondary"">
							
								<table class=""table table-bordered bg-info text-secondary"">
									<tr >
										<td> Total Refunds
										</td>
										<td>0.00
										</td>
									</tr>
									<tr>
										<td> Total Cash In/Out 
										</td>
										<td>0.00
										</td>
									</tr>
									<tr>
										<td> Total Taxable Sales 
										</td>
										<td>0.00
										</td>
									</tr>
									<tr>
										<td> Total Non-Taxable Sales 
										</td>
										<td>0.00
										</td>
									</tr>
									<tr style=""height:60px;"">
										<td> Total Debtor Receipts 
										</td>
										<td>0.00
										</td>
									</tr>
									<tr>
										<td> Total Creditor Payments 
										</td>
										<td>0.00
										</td>
									</tr>
									
								</table>
							</div>
							
							 <div  style=""overflow: hidden; outline: none;"" tabindex=""0"" class=""col-xs-4 text-secondary"">
								
									<table class=""table table-bordered bg-info text-secondary"">
									<tr>
										<td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</td>
										<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</td>
									</tr>
									<tr>
										<td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</td>
										<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</td>
									</tr>
									<tr>
										<td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</td>
										<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</td>
									</tr>
									<tr>
										<td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</td>
										<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</td>
									</tr>
									<tr style=""height:60px;"">
										<td> Total Debtor Refunds 
										</td>
										<td>0.00
										</td>
									</tr>
									<tr>
										<td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</td>
										<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										</td>
									</tr>
									
								</table>
							</div>
					</div>
				</div>
			</div>
				 
          
	 </div>
						
			
	<!-- col-lg-12 end here -->
	</div>
	<!-- End .row -->
            </div>
        </div>
        <!-- End .panel -->
    </div>
    <!-- col-lg-12 end here -->
</div>
                                            
  <!-- Include Bootstrap JS (optional) -->
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""></script>
</body>
</html>

<style>
  .top-align {
    vertical-align: top;
  }
  
  .body{
    margin-top:10px;
    background:#eee;    
}
</style>




                                    ";
        return html;
    }

    public string ReceiptPDF()
    {
        var html = @"
<!DOCTYPE html>
<html>
<head>
  <title>RECEIPT</title>
  <!-- Include Bootstrap CSS -->
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"">
</head>
<body>
<div class=""container bootdey"">
<div class=""row invoice row-printable"">
    <div class=""col-md-10"">
        <!-- col-lg-12 start here -->
        <div class=""panel panel-default plain "" id=""dash_0"">
            <!-- Start .panel -->	
            <div class=""panel-body p30 bg-warning"">
                <div class=""col-md-12"">
				<div class=""col-lg-12"" >
				 <div class=""row  bg-primary"">
                    <!-- Start .row -->
                    <div class=""col-xs-6 "">
                        <!-- col-lg-6 start here -->
                        <div class=""invoice-logo""><img width=""100"" src=""D:\Source Codes\Vezo\VEZO\VEZOWasm\Server\Images\download.png"" alt=""Invoice logo""></div>
                    </div>
                    <!-- col-lg-6 end here -->
                    <div class=""col-xs-6 "">
                        <!-- col-lg-6 start here -->
                        <div class=""invoice-from "">
                            <ul class=""list-unstyled text-right"">
                                <li><strong>NishYur Logistics TA SAITRANS HAULERS</strong></li>
                                <li>27 Railway Street</li>
                                <li>Kok Stad</li>
                                <li>4700</li>
								<li></li>
                            </ul>
                        </div>
                    </div>
                    <!-- col-lg-6 end here -->
				</div>
				</div>
				</div>
		
				
                    <div class=""col-md-12"">
                        <!-- col-lg-12 start here -->
					<div class=""col-lg-12"" >	
						<div class=""row bg-warning"">
						
						<div class=""col-xs-4 from"">
							<ul class=""list-unstyled mb0"">
								<li><strong>Account No:</strong> SHAN001</li>
								<li><strong>Order No:</strong> </li>
								<li><strong>Rep Name:</strong> ***NON-REP SALES*** </li>
								<li><strong>Date:</strong> 24 Jul 23</li>
								<li><strong>Vendor No:</strong></li>
								<li><strong>Client VAT No:</strong> <span class=""label label-danger""></span></li>
								<li><strong>Warehouse:</strong> <span class=""label label-danger""></span></li>
							</ul>
						</div>

						<div class=""col-xs-4 "">
							<p class=""lead marginbottom""></p>
							<p></p>
							<p class=""text-center""><H2><strong>RECEIPT</strong></H2></p>
							<p></p>
							<p></p>
							<p></p>

						</div>

						<div class=""col-xs-4 text-right payment-details"">
							<ul class=""list-unstyled mb0 text-right"">
                                <li><strong>Invoiced To</strong></li>
                                <li>Jakob Smith</li>
                                <li>Roupark 37</li>
                                <li>Randburg</li>
                                <li>JHB</li>
								<li>2014</li>
							    <li>  </li>
								<li>  </li>
							    <li>  </li>
                            </ul>
						</div>
						</div>
					</div>


			
			<div class=""col-lg-12"">			
				<div class=""row bg-primary"" >
				
				<div class=""col-xs-4 from bg-primary"" >
					<ul class=""list-unstyled mb0 text-left"">
						<li><strong>Client Receipt Details</strong></li>
						<li>SHANE</li>
					</ul>
				</div>
				
				<div class=""col-xs-4 from bg-primary"" >
					
				</div>
				
				<div class=""col-xs-4 from bg-primary"" >
					<ul class=""list-unstyled mb0 text-right"">
						<li><strong>Delivery Address</strong></li>
						<li></li>
					</ul>
				</div>
				</div>
			</div>	
			<br/>
			<br/>
			<div class=""col-lg-12"">			
				<div class=""row text-secondary"" >
					<div class=""invoice-items bg-warning"">
                            <div style=""overflow: hidden; outline: none;"" tabindex=""0"" class=""text-secondary"">
                                <table class=""table table-bordered bg-info text-secondary"">
                                    <thead>
                                        <tr>
                                            <th class=""per15 text-center"">Stockcode</th>
                                            <th class=""per20 text-center"">Description</th>
                                            <th class=""per10 text-center"">Quantity</th>
											<th class=""per9 text-center"">Unit</th>
											<th class=""per9 text-center"">Price</th>
											<th class=""per9 text-center"">Disc%</th>
											<th class=""per9 text-center"">Total</th>
											<th class=""per9 text-center"">Tax Amount</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
											<td class="" text-left"">RECEIPT</td>
                                            <td class=""text-left"">REC'D FOR A/C CREDIT</td>
                                            <td class=""text-center""></td>
											<td class=""text-center""></td>
											<td class=""text-center"">0.00</td>
											<td class=""text-center"">0.00</td>
											<td class=""text-center"">1660.00</td>
											<td class=""text-center"">0.00</td>
                                        </tr>
                                        <tr>
											<td class="" text-left"">OWING</td>
											<td class="" text-left"">STILL OWING 990.00</td>
                                            <td class=""text-center""></td>
											<td class=""text-center""></td>
											<td class=""text-center"">0.00</td>
											<td class=""text-center"">0.00</td>
											<td class=""text-center"">0.00</td>
											<td class=""text-center"">0.00</td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                            <td class=""text-center""></td>
                                            <td class=""text-center""></td>
											<td class=""text-center""></td>
											<td class=""text-center""></td>
											<td class=""text-center""></td>
											<td class=""text-center""></td>
											<th class=""text-left"">Totals</th>
                                        </tr>
                                    </tbody>
                                    <tfoot>
										
                                        <tr>
                                            <td colspan=""7"" class=""text-right"">Goods Value:</td>
                                            <td class=""text-left"">1660.00</td>
                                        </tr>
                                        <tr>
                                            <td colspan=""7"" class=""text-right"">Discount:</td>
                                            <td class=""text-left""></td>
                                        </tr>
                                        <tr>
                                            <td colspan=""7"" class=""text-right"">Freight:</td>
                                            <td class=""text-left""></td>
                                        </tr>
                                        <tr>
                                            <td colspan=""7"" class=""text-right"">Vat</td>
                                            <td class=""text-left"">0.00</td>
                                        </tr>
										 <tr>
											
                                            <th colspan=""3"" class=""text-right"">Total Due</th>
                                            <th class=""text-left"">1660.00</th>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                        </div>
				</div>
			</div>	
                        
                        
                        <div class=""invoice-footer mt25"">
						
							 <table class=""table table-bordered bg-info"">
								<tr>
									<td>RECEIVED BY:
									</td>
									<td>EMPTY CRATE:
									</td>
									<td>EMPTY DRUMS:
									</td>
								</tr>
								<tr>
									<td>ISSUED BY:
									</td>
									<td>
									</td>
									<td>
									</td>
								</tr>
							 </table>
                            
                        </div>
						
			<div class=""col-lg-12"">		
						
				<div class=""row bg-primary"" >

				<div class=""col-xs-4 from bg-primary"" >
					<ul class=""list-unstyled mb0 text-left"">
						<li><strong>Contact Details</strong></li>
						<li>Email: saitra@telkomsa.net</li>
						<li>Phone: 07448566470</li>
						<li>Phone: 0731555202</li>
						<li>Phone: 0748566470</li>
						
					</ul>
				</div>

				<div class=""col-xs-4 to bg-primary"">
					<ul class=""list-unstyled mb0 text-center height: 100%"">
						<li><strong>Other Details</strong></li>
						<li>CKS No: 2004/085444/23</li>
						<li>VAT REG NO: 4030217808</li>
						<li></li>
						<li></li>
						
					</ul>
			    </div>

			    <div class=""col-xs-4 text-right payment-details bg-primary height: 100%"">
					<ul class=""list-unstyled mb0"">
						<li><strong>Banking Details</strong></li>
						<li>FNB Business Cheque</li>
						<li>Acc No: 62077840504 </li>
						<li>BR CODE: 220122</li>
						<li></li>
				   </ul>
			    </div>

			</div>
						
                    </div>
                    <!-- col-lg-12 end here -->
                </div>
                <!-- End .row -->
            </div>
        </div>
        <!-- End .panel -->
    </div>
    <!-- col-lg-12 end here -->
</div>
</div>

 <!-- Include Bootstrap JS (optional) -->
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""></script>
</body>
</html>

<style>
  .top-align {
    vertical-align: top;
  }
  
  .body{
    margin-top:10px;
    background:#eee;    
}
</style>



                                    ";
        return html;
    }

    public string TaxInvoicePDF()
    {
        var html = @"<!DOCTYPE html>
						<html>
						<head>
						  <title>Tax Invoice</title>
						  <!-- Include Bootstrap CSS -->
						  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"">
						</head>
						<body>
						<div class=""container bootdey"">
						<div class=""row invoice row-printable"">
							<div class=""col-md-10"">
								<!-- col-lg-12 start here -->
								<div class=""panel panel-default plain "" id=""dash_0"">
									<!-- Start .panel -->	
									<div class=""panel-body p30 bg-warning"">
										<div class=""col-md-12"">
										<div class=""col-lg-12"" >
										 <div class=""row  bg-primary"">
											<!-- Start .row -->
											<div class=""col-xs-6 "">
												<!-- col-lg-6 start here -->
												<div class=""invoice-logo""><img width=""100"" src=""D:\Source Codes\Vezo\VEZO\VEZOWasm\Server\Images\download.png"" alt=""Invoice logo""></div>
											</div>
											<!-- col-lg-6 end here -->
											<div class=""col-xs-6 "">
												<!-- col-lg-6 start here -->
												<div class=""invoice-from "">
													<ul class=""list-unstyled text-right"">
														<li><strong>NishYur Logistics TA SAITRANS HAULERS</strong></li>
														<li>27 Railway Street</li>
														<li>Kok Stad</li>
														<li>4700</li>
														<li></li>
													</ul>
												</div>
											</div>
											<!-- col-lg-6 end here -->
										</div>
										</div>
										</div>
		
				
											<div class=""col-md-12"">
												<!-- col-lg-12 start here -->
											<div class=""col-lg-12"" >	
												<div class=""row bg-warning"">
						
												<div class=""col-xs-4 from"">
													<ul class=""list-unstyled mb0"">
														<li><strong>Account No:</strong> SHAN001</li>
														<li><strong>Order No:</strong> </li>
														<li><strong>Rep Name:</strong> ***NON-REP SALES*** </li>
														<li><strong>Date:</strong> 24 Jul 23</li>
														<li><strong>Vendor No:</strong></li>
														<li><strong>Client VAT No:</strong> <span class=""label label-danger""></span></li>
														<li><strong>Warehouse:</strong> <span class=""label label-danger""></span></li>
													</ul>
												</div>

												<div class=""col-xs-4 "">
													<p class=""lead marginbottom""></p>
													<p></p>
													<p class=""text-center""><H2><strong>Tax Invoice<strong></H2></p>
													<p></p>
													<p></p>
													<p></p>

												</div>

												<div class=""col-xs-4 text-right payment-details"">
													<ul class=""list-unstyled mb0 text-right"">
														<li><strong>Invoiced To</strong></li>
														<li>Jakob Smith</li>
														<li>Roupark 37</li>
														<li>Randburg</li>
														<li>JHB</li>
														<li>2014</li>
														<li>  </li>
														<li>  </li>
														<li>  </li>
													</ul>
												</div>
												</div>
											</div>


			
									<div class=""col-lg-12"">			
										<div class=""row bg-primary"" >
				
										<div class=""col-xs-4 from bg-primary"" >
											<ul class=""list-unstyled mb0 text-left"">
												<li><strong>Client Invoice Details</strong></li>
												<li>SHANE</li>
											</ul>
										</div>
				
										<div class=""col-xs-4 from bg-primary"" >
					
										</div>
				
										<div class=""col-xs-4 from bg-primary"" >
											<ul class=""list-unstyled mb0 text-right"">
												<li><strong>Delivery Address</strong></li>
												<li></li>
											</ul>
										</div>
										</div>
									</div>	
									<br/>
									<br/>
									<div class=""col-lg-12"">			
										<div class=""row text-secondary"" >
											<div class=""invoice-items bg-warning"">
													<div style=""overflow: hidden; outline: none;"" tabindex=""0"" class=""text-secondary"">
														<table class=""table table-bordered bg-info text-secondary"">
															<thead>
																<tr>
																	<th class=""per15 text-center"">Stockcode</th>
																	<th class=""per20 text-center"">Description</th>
																	<th class=""per10 text-center"">Quantity</th>
																	<th class=""per9 text-center"">Unit</th>
																	<th class=""per9 text-center"">Price</th>
																	<th class=""per9 text-center"">Disc%</th>
																	<th class=""per9 text-center"">Total</th>
																	<th class=""per9 text-center"">Tax Amount</th>
																</tr>
															</thead>
															<tbody>
																<tr>
																	<td>20LTR</td>
																	<td class=""text-center"">20LTR IJUBA SPECIAL</td>
																	<td class=""text-center"">20.00</td>
																	<td class=""text-center""></td>
																	<td class=""text-center"">83.00</td>
																	<td class=""text-center"">0.00</td>
																	<td class=""text-center"">1660.00</td>
																	<td class=""text-center"">216.52</td>
																</tr>
																<tr>
																	<td></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																</tr>
																<tr>
																	<td></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																	<td class=""text-center""></td>
																	<th class=""text-left"">Totals</th>
																</tr>
															</tbody>
															<tfoot>
										
																<tr>
																	<td colspan=""7"" class=""text-right"">Goods Value:</td>
																	<td class=""text-left"">1443.48</td>
																</tr>
																<tr>
																	<td colspan=""7"" class=""text-right"">Discount:</td>
																	<td class=""text-left""></td>
																</tr>
																<tr>
																	<td colspan=""7"" class=""text-right"">Freight:</td>
																	<td class=""text-left"">0.00</td>
																</tr>
																<tr>
																	<td colspan=""7"" class=""text-right"">Vat</td>
																	<td class=""text-left"">216.52</td>
																</tr>
																 <tr>
																	<th colspan=""3"" class=""text-left bg-danger"">Account Balance:</th>
																	<th class=""text-left bg-danger"">2650.00</th>
																	<th colspan=""3"" class=""text-right"">Total Due</th>
																	<th class=""text-left"">1660.00</th>
																</tr>
															</tfoot>
														</table>
													</div>
												</div>
										</div>
									</div>	
                        
                        
												<div class=""invoice-footer mt25"">
						
													 <table class=""table table-bordered bg-info"">
														<tr>
															<td>RECEIVED BY:
															</td>
															<td>EMPTY CRATE:
															</td>
															<td>EMPTY DRUMS:
															</td>
														</tr>
														<tr>
															<td>ISSUED BY:
															</td>
															<td>
															</td>
															<td>
															</td>
														</tr>
													 </table>
                            
												</div>
						
									<div class=""col-lg-12"">		
						
										<div class=""row bg-primary"" >

										<div class=""col-xs-4 from bg-primary"" >
											<ul class=""list-unstyled mb0 text-left"">
												<li><strong>Contact Details</strong></li>
												<li>Email: saitra@telkomsa.net</li>
												<li>Phone: 07448566470</li>
												<li>Phone: 0731555202</li>
												<li>Phone: 0748566470</li>
						
											</ul>
										</div>

										<div class=""col-xs-4 to bg-primary"">
											<ul class=""list-unstyled mb0 text-center height: 100%"">
												<li><strong>Other Details</strong></li>
												<li>CKS No: 2004/085444/23</li>
												<li>VAT REG NO: 4030217808</li>
												<li></li>
												<li></li>
						
											</ul>
										</div>

										<div class=""col-xs-4 text-right payment-details bg-primary height: 100%"">
											<ul class=""list-unstyled mb0"">
												<li><strong>Banking Details</strong></li>
												<li>FNB Business Cheque</li>
												<li>Acc No: 62077840504 </li>
												<li>BR CODE: 220122</li>
												<li></li>
										   </ul>
										</div>

									</div>
						
											</div>
											<!-- col-lg-12 end here -->
										</div>
										<!-- End .row -->
									</div>
								</div>
								<!-- End .panel -->
							</div>
							<!-- col-lg-12 end here -->
						</div>
						</div>

						  <!-- Include Bootstrap JS (optional) -->
						  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""></script>
						</body>
						</html>

						<style>
						  .top-align {
							vertical-align: top;
						  }
  
						  .body{
							margin-top:10px;
							background:#eee;    
						}
						</style>
                                    ";
        return html;
    }


    public string GoodsRecievedPDF()
    {
        var html = @"<!DOCTYPE html>
					<html>
					<head>
					  <title>Goods Recieved</title>
					  <!-- Include Bootstrap CSS -->
					  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"">
					</head>
					<body>
					<div class=""container bootdey"">
					<div class=""row invoice row-printable"">
						<div class=""col-md-10"">
							<!-- col-lg-12 start here -->
							<div class=""panel panel-default plain "" id=""dash_0"">
								<!-- Start .panel -->	
								<div class=""panel-body p30 bg-warning"">
									<div class=""col-md-12"">
									<div class=""col-lg-12"" >
									 <div class=""row  bg-primary"">
										<!-- Start .row -->
										<div class=""col-xs-6 "">
											<!-- col-lg-6 start here -->
											<div class=""invoice-logo""><img width=""100"" src=""D:\Source Codes\Vezo\VEZO\VEZOWasm\Server\Images\download.png"" alt=""Invoice logo""></div>
										</div>
										<!-- col-lg-6 end here -->
										<div class=""col-xs-6 "">
											<!-- col-lg-6 start here -->
											<div class=""invoice-from "">
												<ul class=""list-unstyled text-right"">
													<li><strong>NishYur Logistics TA SAITRANS HAULERS</strong></li>
													<li>27 Railway Street</li>
													<li>Kok Stad</li>
													<li>4700</li>
													<li></li>
												</ul>
											</div>
										</div>
										<!-- col-lg-6 end here -->
									</div>
									</div>
									</div>
		
				
										<div class=""col-md-12"">
											<!-- col-lg-12 start here -->
										<div class=""col-lg-12"" >	
											<div class=""row bg-warning"">
						
											<div class=""col-xs-4 from"">
												<ul class=""list-unstyled mb0"">
													<li><strong>Account No:</strong> BUTT001</li>
													<li><strong>Order No:</strong> #936988</li>
													<li><strong>Rep Name:</strong> </li>
													<li><strong>Date:</strong> 24 Jul 23</li>
													<li><strong>Vendor No:</strong></li>
													<li><strong>Client VAT No:</strong> <span class=""label label-danger""></span></li>
													<li><strong>Warehouse:</strong> <span class=""label label-danger""></span></li>
												</ul>
											</div>

											<div class=""col-xs-4 to"">
												<p class=""lead marginbottom""></p>
												<p></p>
												<p><H2><strong>Goods Recieved<strong></H2></p>
												<p></p>
												<p></p>
												<p></p>

											</div>

											<div class=""col-xs-4 text-right payment-details"">
												<ul class=""list-unstyled mb0 text-right"">
													<li><strong>Invoiced To</strong></li>
													<li>Jakob Smith</li>
													<li>Roupark 37</li>
													<li>Randburg</li>
													<li>JHB</li>
													<li>2014</li>
													<li>  </li>
													<li>  </li>
													<li>  </li>
												</ul>
											</div>
						
											</div>
										</div>


			
								<div class=""col-lg-12"">			
									<div class=""row bg-primary"" >
				
									<div class=""col-xs-4 from bg-primary"" >
										<ul class=""list-unstyled mb0 text-left"">
											<li><strong>Client Invoice Details</strong></li>
											<li>Butterworth Brewery</li>
										</ul>
									</div>
				
									<div class=""col-xs-4 from bg-primary"" >
					
									</div>
				
									<div class=""col-xs-4 from bg-primary"" >
										<ul class=""list-unstyled mb0 text-right"">
											<li><strong>Delivery Address</strong></li>
											<li>0002126</li>
										</ul>
									</div>
									</div>
								</div>	
								<br/>
								<br/>
								<div class=""col-lg-12"">			
									<div class=""row text-secondary"" >
										<div class=""invoice-items bg-warning"">
												<div style=""overflow: hidden; outline: none;"" tabindex=""0"" class=""text-secondary"">
													<table class=""table table-bordered bg-info text-secondary"">
														<thead>
															<tr>
																<th class=""per15 text-center"">Stockcode</th>
																<th class=""per20 text-center"">Description</th>
																<th class=""per10 text-center"">Quantity</th>
																<th class=""per9 text-center"">Unit</th>
																<th class=""per9 text-center"">Price</th>
																<th class=""per9 text-center"">Disc%</th>
																<th class=""per9 text-center"">Total</th>
																<th class=""per9 text-center"">Tax Amount</th>
															</tr>
														</thead>
														<tbody>
															<tr>
																<td>20LTR</td>
																<td class=""text-center"">20LTR IJUBA SPECIAL</td>
																<td class=""text-center"">20.00</td>
																<td class=""text-center""></td>
																<td class=""text-center"">83.00</td>
																<td class=""text-center"">0.00</td>
																<td class=""text-center"">1660.00</td>
																<td class=""text-center""></td>
															</tr>
															<tr>
																<td></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
															</tr>
															<tr>
																<td></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
																<td class=""text-center""></td>
																<th class=""text-left"">Totals</th>
															</tr>
														</tbody>
														<tfoot>
															<tr>
																<td colspan=""7"" class=""text-right"">Goods Value:</td>
																<td class=""text-left"">1660.00</td>
															</tr>
															<tr>
																<td colspan=""7"" class=""text-right"">Discount:</td>
																<td class=""text-left"">0.00</td>
															</tr>
															<tr>
																<td colspan=""7"" class=""text-right"">Freight:</td>
																<td class=""text-left"">0.00</td>
															</tr>
															<tr>
																<td colspan=""7"" class=""text-right"">Vat</td>
																<td class=""text-left"">0.00</td>
															</tr>
															 <tr>
																<th colspan=""7"" class=""text-right"">Total Due</th>
																<th class=""text-left"">1660.00</th>
															</tr>
														</tfoot>
													</table>
												</div>
											</div>
									</div>
								</div>	
                        
                        
											<div class=""invoice-footer mt25"">
						
												 <table class=""table table-bordered bg-info"">
													<tr>
														<td>RECEIVED BY:
														</td>
														<td>EMPTY CRATE:
														</td>
														<td>EMPTY DRUMS:
														</td>
													</tr>
													<tr>
														<td>ISSUED BY:
														</td>
														<td>
														</td>
														<td>
														</td>
													</tr>
												 </table>
                            
											</div>
						
								<div class=""col-lg-12"">		
						
									<div class=""row bg-primary"" >

									<div class=""col-xs-4 from bg-primary"" >
										<ul class=""list-unstyled mb0 text-left"">
											<li><strong>Contact Details</strong></li>
											<li>Email: saitra@telkomsa.net</li>
											<li>Phone: 07448566470</li>
											<li>Phone: 0731555202</li>
											<li>Phone: 0748566470</li>
						
										</ul>
									</div>

									<div class=""col-xs-4 to bg-primary"">
										<ul class=""list-unstyled mb0 text-center height: 100%"">
											<li><strong>Other Details</strong></li>
											<li>CKS No: 2004/085444/23</li>
											<li>VAT REG NO: 4030217808</li>
											<li></li>
											<li></li>
						
										</ul>
									</div>

									<div class=""col-xs-4 text-right payment-details bg-primary height: 100%"">
										<ul class=""list-unstyled mb0"">
											<li><strong>Banking Details</strong></li>
											<li>FNB Business Cheque</li>
											<li>Acc No: 62077840504 </li>
											<li>BR CODE: 220122</li>
											<li></li>
									   </ul>
									</div>

								</div>
						
										</div>
										<!-- col-lg-12 end here -->
									</div>
									<!-- End .row -->
								</div>
							</div>
							<!-- End .panel -->
						</div>
						<!-- col-lg-12 end here -->
					</div>
					</div>

					  <!-- Include Bootstrap JS (optional) -->
					  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""></script>
					</body>
					</html>

					<style>
					  .top-align {
						vertical-align: top;
					  }
  
					  .body{
						margin-top:10px;
						background:#eee;    
					}
					</style>
                                    ";
        return html;
    }


 public string ReceiptPDFTemplate(List<InvoiceLineItemsDto> lineitems)
    {
        var lineitemshtml = BuildRecieptLineItems(lineitems);

        var html = @"
            <!DOCTYPE html>
            <html>
            <head>
              <title>RECEIPT</title>
              <!-- Include Bootstrap CSS -->
              <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"">
            </head>
            <body>
            <div class=""container bootdey"">
            <div class=""row invoice row-printable"">
                <div class=""col-md-10"">
                    <!-- col-lg-12 start here -->
                    <div class=""panel panel-default plain "" id=""dash_0"">
                        <!-- Start .panel -->	
                        <div class=""panel-body p30 bg-warning"">
                            <div class=""col-md-12"">
				            <div class=""col-lg-12"" >
				             <div class=""row  bg-primary"">
                                <!-- Start .row -->
                                <div class=""col-xs-6 "">
                                    <!-- col-lg-6 start here -->
                                    <div class=""invoice-logo""><img width=""100"" src=""D:\Source Codes\Vezo\VEZO\VEZOWasm\Server\Images\download.png"" alt=""Invoice logo""></div>
                                </div>
                                <!-- col-lg-6 end here -->
                                <div class=""col-xs-6 "">
                                    <!-- col-lg-6 start here -->
                                    <div class=""invoice-from "">
                                         <ul class=""list-unstyled text-right"">
                                            <li><strong>NishYur Logistics TA SAITRANS HAULERS</strong></li>
                                            <li>27 Railway Street</li>
                                            <li>Kok Stad</li>
                                            <li>4700</li>
								            <li></li>
                                        </ul>
                                    </div>
                                </div>
                                <!-- col-lg-6 end here -->
				            </div>
				            </div>
				            </div>
		
				
                                <div class=""col-md-12"">
                                    <!-- col-lg-12 start here -->
					            <div class=""col-lg-12"" >	
						            <div class=""row bg-warning"">
						
						            <div class=""col-xs-4 from"">
							            <ul class=""list-unstyled mb0"">
								            <li><strong>Account No:</strong>@AccountNo</li>
								            <li><strong>Order No:</strong>@OrderNo</li>
								            <li><strong>Rep Name:</strong>@SalesRep</li>
								            <li><strong>Date:</strong>@Date</li>
								            <li><strong>Vendor No:</strong>@VendorNo</li>
								            <li><strong>Client VAT No:</strong>@VatNo</li>
								            <li><strong>Warehouse:</strong>@Warehouse</span></li>
							            </ul>
						            </div>

						            <div class=""col-xs-4 "">
							            <p class=""lead marginbottom""></p>
							            <p></p>
							            <p class=""text-center""><H2><strong>RECEIPT</strong></H2></p>
							            <p></p>
							            <p></p>
							            <p></p>

						            </div>

						            <div class=""col-xs-4 text-right payment-details"">
							            <ul class=""list-unstyled mb0 text-right"">
                                            <li><strong>Invoiced To</strong></li>
                                            <li>@CompanyName</li>
                                            <li>@AddressLine1</li>
                                            <li>@AddressLine2</li>
                                            <li>@Suburb</li>
								            <li>@City</li>
							                <li>@Province</li>
								            <li>@PostalCode</li>
							                <li>  </li>
                                        </ul>
						            </div>
						            </div>
					            </div>


			
			            <div class=""col-lg-12"">			
				            <div class=""row bg-primary"" >
				
				            <div class=""col-xs-4 from bg-primary"" >
					            <ul class=""list-unstyled mb0 text-left"">
						            <li><strong>Client Receipt Details</strong></li>
						            <li>@CompanyName</li>
						            <li>@SalesRep</li>
					            </ul>
				            </div>
				
				            <div class=""col-xs-4 from bg-primary"" >
					
				            </div>
				
				            <div class=""col-xs-4 from bg-primary"" >
					            <ul class=""list-unstyled mb0 text-right"">
						            <li><strong>Delivery Address</strong></li>
						            <li>@AddressLine1</li>
                                     <li>@AddressLine2</li>
                                     <li>@Suburb</li>
					            </ul>
				            </div>
				            </div>
			            </div>	
			            <br/>
			            <br/>
			            <div class=""col-lg-12"">			
				            <div class=""row text-secondary"" >
					            <div class=""invoice-items bg-warning"">
                                        <div style=""overflow: hidden; outline: none;"" tabindex=""0"" class=""text-secondary"">
                                            <table class=""table table-bordered bg-info text-secondary"">
                                                <thead>
                                                    <tr>
                                                        <th class=""per15 text-center"">Stockcode</th>
                                                        <th class=""per20 text-center"">Description</th>
                                                        <th class=""per10 text-center"">Quantity</th>
											            <th class=""per9 text-center"">Unit</th>
											            <th class=""per9 text-center"">Price</th>
											            <th class=""per9 text-center"">Disc%</th>
											            <th class=""per9 text-center"">Total</th>
											            <th class=""per9 text-center"">Tax Amount</th>
                                                    </tr>
                                                </thead>
                                                <tbody>" + lineitemshtml + @"
                                                    <tr>
                                                        <td></td>
                                                        <td class=""text-center""></td>
                                                        <td class=""text-center""></td>
											            <td class=""text-center""></td>
											            <td class=""text-center""></td>
											            <td class=""text-center""></td>
											            <td class=""text-center""></td>
											            <th class=""text-left"">Totals</th>
                                                    </tr>
                                                </tbody>
                                                <tfoot>
										
                                                    <tr>
                                                        <td colspan=""7"" class=""text-right"">Goods Value:</td>
                                                        <td class=""text-left"">@TotalsAmount</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan=""7"" class=""text-right"">Discount:</td>
                                                        <td class=""text-left"">@TotalsDiscount</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan=""7"" class=""text-right"">Freight:</td>
                                                        <td class=""text-left"">@Freight</td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan=""7"" class=""text-right"">Vat</td>
                                                        <td class=""text-left"">@TotalsVat</td>
                                                    </tr>
										             <tr>
											
                                                        <th colspan=""3"" class=""text-right"">Total Due</th>
                                                        <th class=""text-left"">@TotalDue</th>
                                                    </tr>
                                                </tfoot>
                                            </table>
                                        </div>
                                    </div>
				            </div>
			            </div>	
                        
                        
                                    <div class=""invoice-footer mt25"">
						
							             <table class=""table table-bordered bg-info"">
								            <tr>
									            <td>RECEIVED BY:
									            </td>
									            <td>EMPTY CRATE:
									            </td>
									            <td>EMPTY DRUMS:
									            </td>
								            </tr>
								            <tr>
									            <td>ISSUED BY:
									            </td>
									            <td>
									            </td>
									            <td>
									            </td>
								            </tr>
							             </table>
                            
                                    </div>
						
			            <div class=""col-lg-12"">		
						
				            <div class=""row bg-primary"" >

				            <div class=""col-xs-4 from bg-primary"" >
					            <ul class=""list-unstyled mb0 text-left"">
						            <li><strong>Contact Details</strong></li>
						            <li>Email: saitra@telkomsa.net</li>
						            <li>Phone: 07448566470</li>
						            <li>Phone: 0731555202</li>
						            <li>Phone: 0748566470</li>
						
					            </ul>
				            </div>

				            <div class=""col-xs-4 to bg-primary"">
					            <ul class=""list-unstyled mb0 text-center height: 100%"">
						            <li><strong>Other Details</strong></li>
						            <li>CKS No: 2004/085444/23</li>
						            <li>VAT REG NO: 4030217808</li>
						            <li></li>
						            <li></li>
						
					            </ul>
			                </div>

			                <div class=""col-xs-4 text-right payment-details bg-primary height: 100%"">
					            <ul class=""list-unstyled mb0"">
						            <li><strong>Banking Details</strong></li>
						            <li>FNB Business Cheque</li>
						            <li>Acc No: 62077840504 </li>
						            <li>BR CODE: 220122</li>
						            <li></li>
				               </ul>
			                </div>

			            </div>
						
                                </div>
                                <!-- col-lg-12 end here -->
                            </div>
                            <!-- End .row -->
                        </div>
                    </div>
                    <!-- End .panel -->
                </div>
                <!-- col-lg-12 end here -->
            </div>
            </div>

             <!-- Include Bootstrap JS (optional) -->
              <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""></script>
            </body>
            </html>

            <style>
              .top-align {
                vertical-align: top;
              }
  
              .body{
                margin-top:10px;
                background:#eee;    
            }
            </style> ";
        return html;
    }

 public string BuildRecieptLineItems(List<InvoiceLineItemsDto> lineitems)
 {
        string htmllines = string.Empty;

        foreach (var lineitem in lineitems)
        {
             string htmlstring = @"<tr>
                                  <td class=""text-left"">" + lineitem.StockCode.ToString() + @"</td>
                                  <td class=""text-left"">" + lineitem.Description.ToString() + @"</td>
                                  <td class=""text-center"">" + lineitem.Quanity.ToString() + @"</td>
                                  <td class=""text-center""></td>
                                  <td class=""text-center"">" + lineitem.Price.ToString() + @"</td>
					              <td class=""text-center"">" + lineitem.Discount.ToString() + @"</td>
					              <td class=""text-center"">" + lineitem.Total.ToString() + @"</td>
					              <td class=""text-center"">" + lineitem.VatTotal.ToString() + @"</td>
                               </tr>";

           htmllines = htmllines + htmlstring;
        }

       

        return htmllines;
 }


public string CashTillReconPDFTemplate()
{
    var html = @"
                <!DOCTYPE html>
                <html>
                <head>
                    <title>Cash Till Reconciliation</title>
                    <!-- Include Bootstrap CSS -->
                    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"">
                </head>
                <body>
                <div class=""container bootdey"">
                <div class=""row invoice row-printable"">
                    <div class=""col-md-10"">
                        <!-- col-lg-12 start here -->
                        <div class=""panel panel-default plain "" id=""dash_0"">
                            <!-- Start .panel -->	
                            <div class=""panel-body p30 bg-warning"">
                                <div class=""col-md-12"">
				                <div class=""col-lg-12"" >
				                    <div class=""row  bg-primary"">
                                    <!-- Start .row -->
                                    <div class=""col-xs-6 "">
                                        <!-- col-lg-6 start here -->
                                        <div class=""invoice-logo""><img width=""100"" src=""D:\Source Codes\Vezo\VEZO\VEZOWasm\Server\Images\download.png"" alt=""Invoice logo""></div>
                                    </div>
                                    <!-- col-lg-6 end here -->
                                    <div class=""col-xs-6 "">
                                        <!-- col-lg-6 start here -->
                                        <div class=""invoice-from "">
                                            <ul class=""list-unstyled text-right"">
                                                <li><strong>NishYur Logistics TA SAITRANS HAULERS</strong></li>
                                                <li>27 Railway Street</li>
                                                <li>Kok Stad</li>
                                                <li>4700</li>
								                <li></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <!-- col-lg-6 end here -->
				                </div>
				                </div>
				                </div>
			
                                    <div class=""col-md-12"">
                                        <!-- col-lg-12 start here -->
					                <div class=""col-lg-12"" >	
						                <div class=""row bg-warning"">
						
						                <div class=""col-xs-4 from"">
							                <ul class=""list-unstyled mb0"">
								                <li><strong>For User:</strong> NDU</li>
								                <li><strong>Till Acc:</strong> 32060</li>
								                <li><strong>Date From:</strong>@DateFrom - @DateTo</li>
							                </ul>
						                </div>

						                <div class=""col-xs-4 "">
							                <p class=""lead marginbottom""></p>
							                <p></p>
							                <p class=""text-center""><H5><strong>Cash Till Reconciliation</strong></H5></p>
							                <p></p>
							                <p></p>
							                <p></p>

						                </div>
						                <div class=""col-xs-4 "">
							                <ul class=""list-unstyled mb0"">

								                <li><strong>Type:</strong> Totals Only</li>
								                <li><strong>Vendor No:</strong></li>
								                <li><strong>Date Printed</strong>@DateToday<span class=""label label-danger""></span></li>
								
							                </ul>
						
						                </div>
					                </div>

			
			
			                <div class=""invoice-footer mt25"">
			                <div class=""col-lg-12"">			
				                <div class=""row bg-primary"" >
				
					                <div class=""col-xs-1 from bg-primary"" >
						                <ul class=""list-unstyled mb0 text-left"">
							                <li style=""font-size: 12px;"">USR</li>
						                </ul>
					                </div>
				
					                <div class=""col-xs-1 from bg-primary"" >
						                <ul class=""list-unstyled mb0 text-left"">
							                <li style=""font-size: 12px;"">Rep</li>
						                </ul>
					                </div>
					
					                <div class=""col-xs-1 from bg-primary"" >
						                <ul class=""list-unstyled mb0 text-left"">
							                <li style=""font-size: 12px;"">L</li>
						                </ul>
					                </div>
		
					                <div class=""col-xs-1 from bg-primary"" >
						                <ul class=""list-unstyled mb0 text-left"">
							                <li style=""font-size: 12px;"">AccNo</li>
						                </ul>
					                </div>

				                    <div class=""col-xs-1 from bg-primary"" >
						                <ul class=""list-unstyled mb0 text-left"">
							                <li style=""font-size: 12px;"">Date</li>
						                </ul>
					                </div>
					
					                <div class=""col-xs-1 from bg-primary"" >
						                <ul class=""list-unstyled mb0 text-left"">
							                <li style=""font-size: 12px;"">TP</li>
						                </ul>
					                </div>
					                <div class=""col-xs-1 from bg-primary"" >
						                <ul class=""list-unstyled mb0 text-left"">
							                <li style=""font-size: 12px;"">RefCode</li>
						                </ul>
					                </div>
					                <div class=""col-xs-1 from bg-primary"" >
						                <ul class=""list-unstyled mb0 text-left"">
							                <li style=""font-size: 12px;"">Amount</li>
						                </ul>
					                </div>
					                <div class=""col-xs-1 from bg-primary"" >
						                <ul class=""list-unstyled mb0 text-left"">
							                <li style=""font-size: 12px;"">Description</li>
						                </ul>
					                </div>
					
					                <div class=""col-xs-1 from bg-primary"" >
						                <ul class=""list-unstyled mb0 text-left"">
							                <li style=""font-size: 12px;"">PostDate</li>
						                </ul>
					                </div>
				                </div>
			                </div>
			                </div>

			                <div class=""card"" >
			                    <div class=""card-body"">
				                <h5 class=""card-title""><strong>TILL TOTALS for USER 1 - NDU</strong></h5>
				                <p class=""card-text"">As an added protection against till fraud, the first column lists the Totals from the Till Control file for the selected date(s).
							                The second column  lists Totals calculated now from the actual transactions posted on the selected date(s)
							                If there was Mixed Tender on some postings, some of the totals (Cheques, Cash, etc) ,ay not agree, but the Till Totals should agree.
				                </p>
				
			                    </div>
			                </div>
			
			

			                <div class=""col-lg-12"">			
				                <div class=""row text-secondary"" >
					                <div class=""invoice-items bg-warning "">
                                            <div    tabindex=""0"" class=""col-xs-8 text-secondary"">
							
								                <table class=""table table-bordered bg-info text-secondary"">
								                <tr style=""height:85px;"">
										                <td><h4><strong>Till Totals for the selected date(s)</strong></h4>
										                </td>
									                </tr>
									                <tr>
										                <td > CASH FLOAT
										                </td>
										                <td>@CashFloat
										                </td>
									                </tr>
									                <tr>
										                <td> CASH 
										                </td>
										                <td>@CashTotal
										                </td>
									                </tr>
									                <tr>
										                <td> Cheques 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										                <td> Credit Cards 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										                <td> Electronic Transfers 
										                </td>
										                <td>@ElectronicTransfers
										                </td>
									                </tr>
									                <tr>
										                <td> Vouchers 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									
									                <tr>
										                <td> Other 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										                <td> Mixed Tender 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									
									                <tr>
										                <td> <strong>Total in Till</strong> 
										                </td>
										                <td><strong>@TotalInTill</strong>
										                </td>
									                </tr>
								                </table>
							                </div>
							
							                    <div  style=""overflow: hidden; outline: none;"" tabindex=""0"" class=""col-xs-4 text-secondary"">
								
								                <table class=""table table-bordered bg-info text-secondary"">
									                <tr style=""height:85px;"">
										
										                <td><h5><strong>Totals based on the actual transaction entries</strong></h5>
										                </td>
									                </tr>
								
									                <tr>
										
										                <td>@CashFloat
										                </td>
									                </tr>
									                <tr>
										
										                <td>@CashTotal
										                </td>
									                </tr>
									                <tr>
										
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										
										                <td>@ElectronicTransfers
										                </td>
									                </tr>
									                <tr>
										
										                <td>0.00
										                </td>
									                </tr>
									
									                <tr>
										
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										                <td><strong>@CashTotal</strong>
										                </td>
									                </tr>
								                </table>
							                </div>
					                </div>
				                </div>
			                </div>
			
			                <div class=""col-lg-12"">			
				                <div class=""row text-secondary"" >
					                <div class=""invoice-items bg-warning "">
                                            <div    tabindex=""0"" class=""col-xs-8 text-secondary"">
							
								                <table class=""table table-bordered bg-info text-secondary"">
									                <tr >
										                <td> Total Refunds
										                </td>
										                <td>@TotalRefunds
										                </td>
									                </tr>
									                <tr>
										                <td> Total Cash In/Out 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										                <td> Total Taxable Sales 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										                <td> Total Non-Taxable Sales 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									                <tr style=""height:60px;"">
										                <td> Total Debtor Receipts 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										                <td> Total Creditor Payments 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									
								                </table>
							                </div>
							
							                    <div  style=""overflow: hidden; outline: none;"" tabindex=""0"" class=""col-xs-4 text-secondary"">
								
									                <table class=""table table-bordered bg-info text-secondary"">
									                <tr>
										                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										                </td>
										                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										                </td>
									                </tr>
									                <tr>
										                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										                </td>
										                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										                </td>
									                </tr>
									                <tr>
										                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										                </td>
										                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										                </td>
									                </tr>
									                <tr>
										                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										                </td>
										                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										                </td>
									                </tr>
									                <tr style=""height:60px;"">
										                <td> Total Debtor Refunds 
										                </td>
										                <td>0.00
										                </td>
									                </tr>
									                <tr>
										                <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										                </td>
										                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
										                </td>
									                </tr>
									
								                </table>
							                </div>
					                </div>
				                </div>
			                </div>
				 
          
	                    </div>
						
			
	                <!-- col-lg-12 end here -->
	                </div>
	                <!-- End .row -->
                            </div>
                        </div>
                        <!-- End .panel -->
                    </div>
                    <!-- col-lg-12 end here -->
                </div>
                                            
                    <!-- Include Bootstrap JS (optional) -->
                <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""></script>
                </body>
                </html>

                <style>
                    .top-align {
                    vertical-align: top;
                    }
  
                    .body{
                    margin-top:10px;
                    background:#eee;    
                }
                </style> ";
     return html;
}


public string DeliveryNotePDFTemplate(List<InvoiceLineItemsDto> lineitems)
{
    var lineitemshtml = BuildDeliveryNoteLineItems(lineitems);

    var html = @"
        <!DOCTYPE html>
        <html>
        <head>
            <title>RECEIPT</title>
            <!-- Include Bootstrap CSS -->
            <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"">
        </head>
        <body>
        <div class=""container bootdey"">
        <div class=""row invoice row-printable"">
            <div class=""col-md-10"">
                <!-- col-lg-12 start here -->
                <div class=""panel panel-default plain "" id=""dash_0"">
                    <!-- Start .panel -->	
                    <div class=""panel-body p30 bg-warning"">
                        <div class=""col-md-12"">
				        <div class=""col-lg-12"" >
				            <div class=""row  bg-primary"">
                            <!-- Start .row -->
                            <div class=""col-xs-6 "">
                                <!-- col-lg-6 start here -->
                                <div class=""invoice-logo""><img width=""100"" src=""D:\Source Codes\Vezo\VEZO\VEZOWasm\Server\Images\download.png"" alt=""Invoice logo""></div>
                            </div>
                            <!-- col-lg-6 end here -->
                            <div class=""col-xs-6 "">
                                <!-- col-lg-6 start here -->
                                <div class=""invoice-from "">
                                        <ul class=""list-unstyled text-right"">
                                        <li><strong>NishYur Logistics TA SAITRANS HAULERS</strong></li>
                                        <li>27 Railway Street</li>
                                        <li>Kok Stad</li>
                                        <li>4700</li>
								        <li></li>
                                    </ul>
                                </div>
                            </div>
                            <!-- col-lg-6 end here -->
				        </div>
				        </div>
				        </div>
		
				
                            <div class=""col-md-12"">
                                <!-- col-lg-12 start here -->
					        <div class=""col-lg-12"" >	
						        <div class=""row bg-warning"">
						
						        <div class=""col-xs-4 from"">
							        <ul class=""list-unstyled mb0"">
								        <li><strong>Account No:</strong>@AccountNo</li>
								        <li><strong>Order No:</strong>@OrderNo</li>
								        <li><strong>Rep Name:</strong>@SalesRep</li>
								        <li><strong>Date:</strong>@Date</li>
								        <li><strong>Vendor No:</strong>@VendorNo</li>
								        <li><strong>Client VAT No:</strong>@VatNo</li>
								        <li><strong>Warehouse:</strong>@Warehouse</span></li>
							        </ul>
						        </div>

						        <div class=""col-xs-4 "">
							        <p class=""lead marginbottom""></p>
							        <p></p>
							        <p class=""text-center""><H2><strong>Delivery Note</strong></H2></p>
							        <p></p>
							        <p></p>
							        <p></p>

						        </div>

						        <div class=""col-xs-4 text-right payment-details"">
							        <ul class=""list-unstyled mb0 text-right"">
                                        <li><strong>Invoiced To</strong></li>
                                        <li>@CompanyName</li>
                                        <li>@AddressLine1</li>
                                        <li>@AddressLine2</li>
                                        <li>@Suburb</li>
								        <li>@City</li>
							            <li>@Province</li>
								        <li>@PostalCode</li>
							            <li>  </li>
                                    </ul>
						        </div>
						        </div>
					        </div>


			
			        <div class=""col-lg-12"">			
				        <div class=""row bg-primary"" >
				
				        <div class=""col-xs-4 from bg-primary"" >
					        <ul class=""list-unstyled mb0 text-left"">
						        <li><strong>Client Receipt Details</strong></li>
						        <li>@CompanyName</li>
						        <li>@SalesRep</li>
					        </ul>
				        </div>
				
				        <div class=""col-xs-4 from bg-primary"" >
					
				        </div>
				
				        <div class=""col-xs-4 from bg-primary"" >
					        <ul class=""list-unstyled mb0 text-right"">
						        <li><strong>Delivery Address</strong></li>
						        <li>@AddressLine1</li>
                                    <li>@AddressLine2</li>
                                    <li>@Suburb</li>
					        </ul>
				        </div>
				        </div>
			        </div>	
			        <br/>
			        <br/>
			        <div class=""col-lg-12"">			
				        <div class=""row text-secondary"" >
					        <div class=""invoice-items bg-warning"">
                                    <div style=""overflow: hidden; outline: none;"" tabindex=""0"" class=""text-secondary"">
                                        <table class=""table table-bordered bg-info text-secondary"">
                                            <thead>
                                                <tr>
                                                    <th class=""per15 text-center"">Stockcode</th>
                                                    <th class=""per20 text-center"">Description</th>
                                                    <th class=""per10 text-center"">Quantity</th>
											        <th class=""per9 text-center"">Unit</th>
											            
                                                </tr>
                                            </thead>
                                            <tbody>" + lineitemshtml + @"
                                                <tr>
                                                    <td></td>
                                                    <td class=""text-center""></td>
                                                    <td class=""text-center""></td>
											        <td class=""text-center""></td>
                                                </tr>
                                            </tbody>
                                            <tfoot>
										
                                                    
                                            </tfoot>
                                        </table>
                                    </div>
                                </div>
				        </div>
			        </div>	
                        
                        
                                <div class=""invoice-footer mt25"">
						
							            <table class=""table table-bordered bg-info"">
								        <tr>
									        <td>RECEIVED BY:
									        </td>
									        <td>EMPTY CRATE:
									        </td>
									        <td>EMPTY DRUMS:
									        </td>
								        </tr>
								        <tr>
									        <td>ISSUED BY:
									        </td>
									        <td>
									        </td>
									        <td>
									        </td>
								        </tr>
							            </table>
                            
                                </div>
						
			        <div class=""col-lg-12"">		
						
				        <div class=""row bg-primary"" >

				        <div class=""col-xs-4 from bg-primary"" >
					        <ul class=""list-unstyled mb0 text-left"">
						        <li><strong>Contact Details</strong></li>
						        <li>Email: saitra@telkomsa.net</li>
						        <li>Phone: 07448566470</li>
						        <li>Phone: 0731555202</li>
						        <li>Phone: 0748566470</li>
						
					        </ul>
				        </div>

				        <div class=""col-xs-4 to bg-primary"">
					        <ul class=""list-unstyled mb0 text-center height: 100%"">
						        <li><strong>Other Details</strong></li>
						        <li>CKS No: 2004/085444/23</li>
						        <li>VAT REG NO: 4030217808</li>
						        <li></li>
						        <li></li>
						
					        </ul>
			            </div>

			            <div class=""col-xs-4 text-right payment-details bg-primary height: 100%"">
					        <ul class=""list-unstyled mb0"">
						        <li><strong>Banking Details</strong></li>
						        <li>FNB Business Cheque</li>
						        <li>Acc No: 62077840504 </li>
						        <li>BR CODE: 220122</li>
						        <li></li>
				            </ul>
			            </div>

			        </div>
						
                            </div>
                            <!-- col-lg-12 end here -->
                        </div>
                        <!-- End .row -->
                    </div>
                </div>
                <!-- End .panel -->
            </div>
            <!-- col-lg-12 end here -->
        </div>
        </div>

            <!-- Include Bootstrap JS (optional) -->
            <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""></script>
        </body>
        </html>

        <style>
            .top-align {
            vertical-align: top;
            }
  
            .body{
            margin-top:10px;
            background:#eee;    
        }
        </style> ";
    return html;
}


    public string BuildDeliveryNoteLineItems(List<InvoiceLineItemsDto> lineitems)
    {
        string htmllines = string.Empty;

        foreach (var lineitem in lineitems)
        {
            string htmlstring = @"<tr>
                                  <td class=""text-left"">" + lineitem.StockCode.ToString() + @"</td>
                                  <td class=""text-left"">" + lineitem.Description.ToString() + @"</td>
                                  <td class=""text-center"">" + lineitem.Quanity.ToString() + @"</td>
                                  <td class=""text-center""></td>
                               </tr>";

            htmllines = htmllines + htmlstring;
        }



        return htmllines;
    }

}
