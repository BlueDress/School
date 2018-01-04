<?php

/* :project:edit.html.twig */
class __TwigTemplate_472af7ecc306755c4e2c7e7cfa39a6fdd2712b7425ef7a3a903b98a8685897c2 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":project:edit.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_6acebb54a1b3f7fcd775fdeebc2351fc1ac523c55977de2d9fce8618ea0fc0af = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6acebb54a1b3f7fcd775fdeebc2351fc1ac523c55977de2d9fce8618ea0fc0af->enter($__internal_6acebb54a1b3f7fcd775fdeebc2351fc1ac523c55977de2d9fce8618ea0fc0af_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":project:edit.html.twig"));

        $__internal_cfcf39320bf60897838750e4fe87df1df3eaff0ed38303aac797f61989e215ff = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cfcf39320bf60897838750e4fe87df1df3eaff0ed38303aac797f61989e215ff->enter($__internal_cfcf39320bf60897838750e4fe87df1df3eaff0ed38303aac797f61989e215ff_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":project:edit.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_6acebb54a1b3f7fcd775fdeebc2351fc1ac523c55977de2d9fce8618ea0fc0af->leave($__internal_6acebb54a1b3f7fcd775fdeebc2351fc1ac523c55977de2d9fce8618ea0fc0af_prof);

        
        $__internal_cfcf39320bf60897838750e4fe87df1df3eaff0ed38303aac797f61989e215ff->leave($__internal_cfcf39320bf60897838750e4fe87df1df3eaff0ed38303aac797f61989e215ff_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_ca1f9fdec2b7a2d0bdb58615c7bb10ffa58aa1d0288ef394a65a56ef9165c558 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ca1f9fdec2b7a2d0bdb58615c7bb10ffa58aa1d0288ef394a65a56ef9165c558->enter($__internal_ca1f9fdec2b7a2d0bdb58615c7bb10ffa58aa1d0288ef394a65a56ef9165c558_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_af762f62a99a32a9af23c4f3a1be76e8655d9d451ef8c8f6076d1e354bdb4d95 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_af762f62a99a32a9af23c4f3a1be76e8655d9d451ef8c8f6076d1e354bdb4d95->enter($__internal_af762f62a99a32a9af23c4f3a1be76e8655d9d451ef8c8f6076d1e354bdb4d95_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "title", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\">";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "description", array()), "html", null, true);
        echo "</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"";
        // line 19
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "budget", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_af762f62a99a32a9af23c4f3a1be76e8655d9d451ef8c8f6076d1e354bdb4d95->leave($__internal_af762f62a99a32a9af23c4f3a1be76e8655d9d451ef8c8f6076d1e354bdb4d95_prof);

        
        $__internal_ca1f9fdec2b7a2d0bdb58615c7bb10ffa58aa1d0288ef394a65a56ef9165c558->leave($__internal_ca1f9fdec2b7a2d0bdb58615c7bb10ffa58aa1d0288ef394a65a56ef9165c558_prof);

    }

    public function getTemplateName()
    {
        return ":project:edit.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  82 => 26,  72 => 19,  65 => 15,  58 => 11,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"{{ project.title }}\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\">{{ project.description }}</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"{{ project.budget }}\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}

", ":project:edit.html.twig", "C:\\Exam 03-Jan-2018\\PHP-Skeleton\\app/Resources\\views/project/edit.html.twig");
    }
}
